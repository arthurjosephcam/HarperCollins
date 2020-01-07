/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/



/*
in real life, inserting with post deployment script is not a good idea.
better is UpSert. I did not use this to keep my code simple but here is a sample:

MERGE [dbo].[Categories] AS [T]
USING 
(
	VALUES (1,'Appraisal')
	      ,(2,'Borrowers')
	      ,(3,'Funder')
		  ,(4,'Insurance')
		  ,(5,'Loan')
		  ,(6,'Miscellaneous')
		  ,(7,'Pipeline')
		  ,(8,'Status')

) AS [S] ([CategoryId],[CategoryName])
ON [T].[CategoryId] = [S].[CategoryId]

WHEN MATCHED AND [T].[CategoryName] <> [S].[CategoryName] THEN
	UPDATE SET [CategoryName] = [S].[CategoryName]

WHEN NOT MATCHED THEN
	INSERT ([CategoryId],[CategoryName])
	VALUES ([S].[CategoryId],[S].[CategoryName])

WHEN NOT MATCHED BY SOURCE THEN
	DELETE;

*/

