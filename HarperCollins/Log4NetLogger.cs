//using System;
//using System.Collections.Concurrent;
//using System.IO;
//using System.Reflection;
//using System.Xml;
//using log4net;
//using log4net.Config;
//using log4net.Repository;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Logging;

//namespace HarperCollins.WebApplication
//{
//    public static class Log4netExtensions
//    {
//        public static ILoggerFactory AddLog4Net(this ILoggerFactory LoggerFactory, IHttpContextAccessor HttpContextAccessor, String ConfigurationFile)
//        {
//            LoggerFactory.AddProvider(new Log4NetProvider(HttpContextAccessor, ConfigurationFile));
//            return LoggerFactory;
//        }

//        public static ILoggerFactory AddLog4Net(this ILoggerFactory LoggerFactory, IHttpContextAccessor HttpContextAccessor, XmlElement XmlConfiguration)
//        {
//            LoggerFactory.AddProvider(new Log4NetProvider(HttpContextAccessor, XmlConfiguration));
//            return LoggerFactory;
//        }

//        public static ILoggerFactory AddLog4Net(this ILoggerFactory LoggerFactory, IHttpContextAccessor HttpContextAccessor, ILoggerRepository LoggerRepository)
//        {
//            LoggerFactory.AddProvider(new Log4NetProvider(HttpContextAccessor, LoggerRepository));
//            return LoggerFactory;
//        }
//    }

//    public class Log4NetProvider : ILoggerProvider
//    {
//        protected ILogger Logger { get; set; }
//        protected IHttpContextAccessor HttpContextAccessor { get; }
//        protected ConcurrentDictionary<String, ILogger> Loggers { get; } 

//        public Log4NetProvider(IHttpContextAccessor HttpContextAccessor)
//        {
//            this.HttpContextAccessor = HttpContextAccessor;
//            Loggers = new ConcurrentDictionary<String, ILogger>();

//            // If not configured try to configure using the default
//            if (!LogManager.GetRepository(Assembly.GetEntryAssembly()).Configured)
//                XmlConfigurator.Configure(new FileInfo("log4net.config")); 
//        }

//        public Log4NetProvider(IHttpContextAccessor HttpContextAccessor, String ConfigurationFile) : this(HttpContextAccessor)
//        {
//            XmlConfigurator.Configure(new FileInfo(ConfigurationFile));
//        }

//        public Log4NetProvider(IHttpContextAccessor HttpContextAccessor, ILoggerRepository LoggerRepository) : this(HttpContextAccessor)
//        {
//            XmlConfigurator.Configure(LoggerRepository);
//        }

//        public Log4NetProvider(IHttpContextAccessor HttpContextAccessor, XmlElement XmlConfiguration) : this(HttpContextAccessor)
//        {
//            XmlConfigurator.Configure(XmlConfiguration);
//        }

//        public ILogger CreateLogger(String Category)
//        {
//            return Loggers.GetOrAdd(Category, new Log4NetLogger(Category,HttpContextAccessor));
//        }

//        public void Dispose()
//        {
//            Loggers.Clear();
//        }
//    }

//    public class Log4NetLogger : Microsoft.Extensions.Logging.ILogger
//    {
//        protected String Category { get; set; }
//        protected ILog Logger { get; set; }
//        protected IHttpContextAccessor HttpContextAccessor { get; }

//        public Log4NetLogger(String Category, IHttpContextAccessor HttpContextAccessor)
//        {
//            this.Category = Category;
//            this.HttpContextAccessor = HttpContextAccessor;

//            // Throw exception if Log4Net has not been configured
//            if (!LogManager.GetRepository().Configured)
//            {
//                throw new Exception("Log4Net has not been configured");
//            }

//            // Create an instance of the logger
//            this.Logger = LogManager.GetLogger(typeof(Log4NetLogger));
//        }

//        public IDisposable BeginScope<TState>(TState State)
//        {
//            // For now Scope is not supported
//            return null;
//        }

//        public bool IsEnabled(LogLevel LogLevel)
//        {
//            // Return value based on Logger configuration
//            switch (LogLevel)
//            {
//                case LogLevel.Critical:
//                    return Logger.IsFatalEnabled;
//                case LogLevel.Debug:
//                case LogLevel.Trace:
//                    return Logger.IsDebugEnabled;
//                case LogLevel.Error:
//                    return Logger.IsErrorEnabled;
//                case LogLevel.Information:
//                    return Logger.IsInfoEnabled;
//                case LogLevel.Warning:
//                    return Logger.IsWarnEnabled;
//                default:
//                    throw new ArgumentOutOfRangeException(nameof(LogLevel));
//            }
//        }

//        public void Log<TState>(LogLevel LogLevel, EventId EventId, TState State, Exception Exception, Func<TState, Exception, String> Formatter)
//        {
//            // Throw exception if no formatter was provided
//            if (Formatter == null)
//                throw new ArgumentNullException(nameof(Formatter));

//            // Return if logging level is not enabled
//            if (!IsEnabled(LogLevel))
//                return;

//            // Format the message
//            String message = Formatter(State, Exception);

//            // Add the Category 
//            ThreadContext.Properties["Category"] = Category;

//            // Add information from HttpContext if available
//            if (HttpContextAccessor.HttpContext != null)
//            {
//                var HttpContext = HttpContextAccessor.HttpContext;

//                if(HttpContext.User != null && HttpContext.User.Identity != null)
//                    ThreadContext.Properties["Principal"] = HttpContext.User.Identity.Name;

//                if (HttpContext.Connection != null && HttpContext.Connection.RemoteIpAddress != null)
//                    ThreadContext.Properties["UserAddress"] = HttpContext.Connection.RemoteIpAddress.ToString();

//                if (HttpContext.Request != null)
//                {
//                    ThreadContext.Properties["Method"] = HttpContext.Request.Method;

//                    var uri = HttpContext.Request.Path.Value;
//                    var parameters = "";
//                    if (HttpContext.Request.Query.Count > 0)
//                    {                        
//                        foreach (var key in HttpContext.Request.Query.Keys)
//                        {
//                            parameters += "/" + key + "=" + HttpContext.Request.Query[key].ToString();
//                        }
//                    }
//                    ThreadContext.Properties["Uri"] = uri + parameters;
//                }

//                if (HttpContext.Response != null)
//                {
//                    ThreadContext.Properties["ResponseCode"] = HttpContext.Response.StatusCode.ToString();
//                }

//                if (HttpContext.Request != null && HttpContext.Request.Headers.ContainsKey("User-Agent"))
//                {
//                    ThreadContext.Properties["UserAgent"] = HttpContext.Request.Headers["User-Agent"].ToString();
//                }
//            }

//            // Log the message and exception
//            if (!String.IsNullOrEmpty(message) || Exception != null)
//            {

//                switch (LogLevel)
//                {
//                    case LogLevel.Critical:
//                        Logger.Fatal(message);
//                        break;
//                    case LogLevel.Debug:
//                    case LogLevel.Trace:
//                        Logger.Debug(message);
//                        break;
//                    case LogLevel.Error:
//                        Logger.Error(message, Exception);
//                        break;
//                    case LogLevel.Information:
//                        Logger.Info(message);
//                        break;
//                    case LogLevel.Warning:
//                        Logger.Warn(message);
//                        break;
//                    default:
//                        Logger.Warn($"Encountered unknown log level {Logger}, writing out as Info.");
//                        Logger.Info(message, Exception);
//                        break;
//                }
//            }
//        }
//    }

//}
