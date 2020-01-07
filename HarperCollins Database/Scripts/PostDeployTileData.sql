﻿MERGE [CustomerData] AS [T]
USING 
(
	VALUES 
		('9781404110380','CU GIRL  STOP APOLOGIZING WITH BONUS CHAPTER  B N','Hollis Rachel','Hardcover',24.99),
	('9780062834942','THE OTHER WOMAN:A NOVEL','Silva Daniel','Paperback',16.99),
	('9781400209606','GIRL  STOP APOLOGIZING','Hollis Rachel','Hardcover',24.99),
	('9780007823505','XSEUSS MINI HB LIBRARY AUS','None','Hardcover',119.80),
	('9780062740373','THE HUNTRESS:A NOVEL','Quinn Kate','Paperback',16.99),
	('9780062863324','IN ANOTHER TIME:A NOVEL','Cantor Jillian','Paperback',16.99),
	('9780062319791','I''LL BE GONE IN THE DARK:ONE WOMAN''S OBSESSIVE SEA','Mcnamara Michelle','Paperback',17.99),
	('9780062938602','THE LAST ROMANTICS B&N EXCLUSIVE EDITION:A NOVEL','Conklin Tara','Hardcover',26.99),
	('9780062104908','The School for Good and Evil','Chainani Soman','Paperback',8.99),
	('9780062498564','ON THE COME UP','Thomas Angie','Hardcover',18.99),
	('9780062498533','THE HATE U GIVE','Thomas Angie','Hardcover',18.99),
	('9780008324292','FINDING STEVIE','Glass, Cathy','Paperback',7.99),
	('9780062381804','CRUCIBLE:A THRILLER','Rollins James','Ebook',22.99),
	('9780310604037','CU PURPOSE DRIVEN LIFE MM PACE','Warren Rick','Mass Market',6.99),
	('9781400209743','GODS PROMISES FOR GRADUATES  CLASS OF 2019   NAVY','Countryman Jack','Hardcover',14.99),
	('9780785216247','CAPITAL GAINES','Gaines Chip','Paperback',17.99),
	('9780062674951','THE GOWN:A NOVEL OF THE ROYAL WEDDING','Robson Jennifer','Paperback',16.99),
	('9780785220862','I DECLARE WAR','Lusko Levi','Paperback',16.99),
	('9781400201655','GIRL  WASH YOUR FACE','Hollis Rachel','Hardcover',22.99),
	('9780310453345','NIV  ARTISAN COLLECTION BIBLE  CLOTH OVER BOARD  N','~','Hardcover',49.99),
	('9781400322787','PRECIOUS MOMENTS  LITTLE BOOK OF PRAYERS','~','Other',9.99),
	('9780062316097','SAPIENS:A BRIEF HISTORY OF HUMANKIND','Harari Yuval Noah','Hardcover',37.50),
	('9781400207404','SIX HOURS ONE FRIDAY','Lucado Max','Hardcover',16.99),
	('9780718098988','CU QUEST FOR CHARACTER GRACE TO YOU','Macarthur John','Hardcover',14.99),
	('9780062663108','HUNTING EL CHAPO:THE INSIDE STORY OF THE AMERICAN','Hogan Andrew','Paperback',17.99),
	('9780060989156','THE DIRT:CONFESSIONS OF THE WORLD''S MOST NOTORIOUS','Lee Tommy','Paperback',19.99),
	('9780008245719','FIRST MAN IN','Middleton, Ant','Hardcover',20.00),
	('9780310094142','NIV  PREMIUM GIFT BIBLE  LEATHERSOFT  PINK BROWN','~','Hardcover',24.99),
	('9780062866004','THE GOOD EGG','John Jory','Hardcover',17.99),
	('9780062797162','THE TATTOOIST OF AUSCHWITZ:A NOVEL','Morris Heather','Ebook',13.99),
	('9780061730337','THE BOY WHO HARNESSED THE WIND:CREATING CURRENTS O','Kamkwamba William','Paperback',15.99),
	('9780062935151','OPPOSITE OF ALWAYS (TARGET EDITION)','Reynolds Justin A','Hardcover',17.99),
	('9780718098506','LEADERSHIFT','Maxwell John','Hardcover',27.99),
	('9780062843760','DISNEY JUNIOR FANCY NANCY: CAMP FANCY','Tucker Krista','Paperback',4.99),
	('9780062315007','THE ALCHEMIST','Coelho Paulo','Paperback',16.99),
	('9780062572233','AMERICAN GODS:A NOVEL','Gaiman Neil','Paperback',19.99),
	('9780778308294','A JUSTIFIED MURDER','Deveraux Jude','Hardcover',26.99),
	('9780310765233','WITHIN THESE LINES','Morrill Stephanie','Hardcover',17.99),
	('9780062748331','AMERICAN DUCHESS:A NOVEL OF CONSUELO VANDERBILT','Harper Karen','Paperback',15.99),
	('9781400201662','GIRL  WASH YOUR FACE','Hollis Rachel','Ebook',17.99),
	('9781400201754','SERIAL KILLERS DAUGHTER','Rawson Kerri','Hardcover',22.99),
	('9780062310705','KING''S CAGE','Aveyard Victoria','Paperback',12.99),
	('9780062335548','ENDLING #1: THE LAST','Applegate Katherine','Paperback',7.99),
	('9780008299583','DANGEROUS HERO','Bower, Tom','Paperback',14.99),
	('9780062846532','FANCY NANCY: NANCY CLANCY, SUPER SLEUTH (SPECIAL E','O''Connor Jane','Paperback',4.99),
	('9780062846549','FANCY NANCY: NANCY CLANCY, SECRET ADMIRER (SPECIAL','O''Connor Jane','Paperback',4.99),
	('9780062846563','FANCY NANCY: NANCY CLANCY, SECRET OF THE SILVER KE','O''Connor Jane','Paperback',4.99),
	('9780062846587','FANCY NANCY: NANCY CLANCY, SOCCER MANIA (SPECIAL E','O''Connor Jane','Paperback',4.99),
	('9780062846594','FANCY NANCY: NANCY CLANCY SEEKS A FORTUNE (SPECIAL','O''Connor Jane','Paperback',4.99),
	('9780062846556','FANCY NANCY: NANCY CLANCY SEES THE FUTURE (SPECIAL','O''Connor Jane','Paperback',4.99),
	('9780062846570','FANCY NANCY: NANCY CLANCY, STAR OF STAGE AND SCREE','O''Connor Jane','Paperback',4.99),
	('9780062846600','FANCY NANCY: NANCY CLANCY: MY SECRET DIARY (SPECIA','O''Connor Jane','Paperback',4.99),
	('9781404110762','CU JESUS CODE  TURNING POINT','Hawkins Os','Hardcover',14.99),
	('9780061450815','MIRACLES HAPPEN SPA SPEC MKTS','Ash Mary Kay','Hardcover',0.00),
	('9780718040130','JAMES CODE','Hawkins O S','Hardcover',14.99),
	('9780718089948','DANIEL CODE','Hawkins O S','Hardcover',14.99),
	('9780062404343','PETE THE CAT AND THE COOL CAT BOOGIE','Dean James','Hardcover',17.99),
	('9780008172145','ELEANOR OLIPHANT IS COMPLETELY FINE','Honeyman, Gail','Paperback',8.99),
	('9780062838636','THE ALTER EGO EFFECT:THE POWER OF SECRET IDENTITIE','Herman Todd','Hardcover',26.99),
	('9780008164621','MIDNIGHT GANG THE','Walliams, David','Paperback',0.00),
	('9780008208240','BLOOD ROAD THE','Macbride, Stuart','Paperback',7.99),
	('9780008307738','FIRE AND BLOOD','Martin, George R.R.','Hardcover',25.00),
	('9781443456623','THE 5 AM CLUB:OWN YOUR MORNING. ELEVATE YOUR LIFE.','Sharma Robin','Hardcover',29.99),
	('9780062795823','FAIL UNTIL YOU DON''T:FIGHT GRIND REPEAT','Bones Bobby','Paperback',16.99),
	('9780061120060','THEIR EYES WERE WATCHING GOD','Hurston Zora Neale','Paperback',17.99),
	('9780062877000','THE TATTOOIST OF AUSCHWITZ INTL:A NOVEL','Morris Heather','Paperback',19.99),
	('9780310337508','PURPOSE DRIVEN LIFE','Warren Rick','Paperback',17.99),
	('9781400203758','LOVE DOES','Goff Bob','Paperback',17.99),
	('9780310766483','NIV  PSALMS AND PROVERBS  PURPLE','~','Hardcover',19.99),
	('9780310708254','JESUS STORYBOOK BIBLE','Lloyd Jones Sally','Hardcover',18.99),
	('9780062397348','A PEOPLE''S HISTORY OF THE UNITED STATES','Zinn Howard','Paperback',19.99),
	('9780008270889','SISTER''S SORROW A','Neale, Kitty','Paperback',7.99),
	('9780062839282','MAGIC IS DEAD:MY JOURNEY INTO THE WORLD''S MOST SEC','Frisch Ian','Hardcover',26.99),
	('9780778307938','UNFORGETTABLE YOU','Novak Brenda','Paperback',7.99),
	('9780062748201','BARRACOON:THE STORY OF THE LAST "BLACK CARGO"','Hurston Zora Neale','Hardcover',24.99),
	('9780778351252','CALIFORNIA GIRLS','Mallery Susan','Paperback',15.99),
	('9780062844071','SOLDIER DOGS #3: SECRET MISSION: GUAM','Sutter Marcus','Paperback',7.99),
	('9780008308711','IF YOU GO DOWN TO THE WOODS','Adams, Seth C.','Paperback',15.99),
	('9780062741868','PLAYING FOR KEEPS  EPB:A HEARTBREAKER BAY NOVEL','Shalvis Jill','Ebook',7.99),
	('9780008297114','HUNTING PARTY THE','Foley, Lucy','Hardcover',24.99),
	('9780310354468','DAILY GUIDEPOSTS 2019','Guideposts','Hardcover',19.99),
	('9780778330271','THE LOST GIRLS OF PARIS','Jenoff Pam','Paperback',16.99),
	('9780062691316','WE SET THE DARK ON FIRE','Mejia Tehlor Kay','Hardcover',17.99),
	('9780062455963','THE HISTORY OF THE FUTURE:OCULUS, FACEBOOK, AND TH','Harris Blake J','Hardcover',28.99),
	('9781400201679','GIRL  WASH YOUR FACE','Hollis Rachel','Digital Audio',21.99),
	('9780062676054','THE SCOUNDREL IN HER BED:A SIN FOR ALL SEASONS NOV','Heath Lorraine','Mass Market',7.99),
	('9780062852779','THE POLAR BEAR EXPEDITION:THE HEROES OF AMERICA''S','Nelson James Carl','Hardcover',28.99),
	('9780062377890','FANCY NANCY: BUBBLES, BUBBLES, AND MORE BUBBLES!','O''Connor Jane','Paperback',4.99),
	('9780008234188','WOMAN IN THE WINDOW THE','Finn, A. J.','Paperback',8.99),
	('9780062259677','BIRD BOX:A NOVEL','Malerman Josh','Ebook',13.99),
	('9781443455596','LIVE HAPPY:THE BEST WAYS TO MAKE YOUR HOUSE A HOME','Wilson Kortney','Paperback',34.99),
	('9780310631910','CU NIV  VALUE OUTREACH BIBLE  LS  RESCUE HOUSE','~','Other',29.99),
	('9780008326081','DRAW WITH BING! WIPE-CLEAN ACTIVITY BOOK','No Contributors Listed','Paperback',4.99),
	('9781335666437','OHURLEY BORN','Roberts Nora','Paperback',7.99),
	('9780062407801','NEVER SPLIT THE DIFFERENCE:NEGOTIATING AS IF YOUR','Voss Chris','Hardcover',32.50),
	('9780062413604','CHASING HILLARY:ON THE TRAIL OF THE FIRST WOMAN PR','Chozick Amy','Paperback',17.99),
	('9780310094067','NIV  PREMIUM GIFT BIBLE  LEATHERSOFT  BROWN  RED L','~','Hardcover',19.99),
	('9780060652920','MERE CHRISTIANITY PB','Lewis C S','Paperback',15.99),
	('9780062845221','HUSH, LITTLE BUNNY','Stein David Ezra','Hardcover',17.99),
	('9780718096267','RVR60 HOLY BIBLE   ECONOMIC EDITION','~','Paperback',2.99),
	('9781400209736','GODS PROMISES FOR GRADUATES  CLASS OF 2019   BLACK','Countryman Jack','Hardcover',14.99),
	('9780310094340','ITS NOT SUPPOSED TO BE THIS WAY STUDY GUIDE','Terkeurst Lee Thorp','Paperback',12.99),
	('9780062674968','GOWN, THE:A NOVEL OF THE ROYAL WEDDING','Robson Jennifer','Ebook',13.99),
	('9780062797100','ALIENATED AMERICA:WHY SOME PLACES THRIVE WHILE OTH','Carney Timothy P','Hardcover',27.99),
	('9780778369189','THE FAMILIARS','Halls Stacey','Hardcover',26.99),
	('9780062678447','THE WOMAN IN THE WINDOW:A NOVEL','Finn A J','Ebook',21.99),
	('9780008312831','5 AM CLUB THE','Sharma, Robin','Paperback',12.99),
	('9780062741882','PLAYING FOR KEEPS:A HEARTBREAKER BAY NOVEL','Shalvis Jill','Mass Market',7.99),
	('9780062654205','THE ALICE NETWORK:A NOVEL','Quinn Kate','Ebook',13.99),
	('9780778368960','CALIFORNIA GIRLS','Mallery Susan','Hardcover',26.99),
	('9781400215393','LEADERSHIFT','Maxwell John','Hardcover',27.99),
	('9780718039868','ITS NOT SUPPOSED TO BE THIS WAY','Terkeurst Lysa','Ebook',19.99),
	('9780007371464','GANGSTA GRANNY','Walliams, David','Paperback',6.99),
	('9780007453627','AWFUL AUNTIE','Walliams, David','Paperback',0.00),
	('9780718085858','SECRETS AT CEDAR CABIN','Coble Colleen','Ebook',12.99),
	('9780062884183','SHAZAM!: FREDDY''S GUIDE TO SUPER HERO-ING','Behling Steve','Paperback',9.99),
	('9780062890894','SHAZAM!: THE DELUXE JUNIOR NOVEL','Glass Calliope','Hardcover',9.99),
	('9780007263868','Stuck','Jeffers, Oliver','Hardcover',12.99),
	('9780310437888','NIV  MENS DEVOTIONAL BIBLE  LEATHERSOFT  BLACK BLU','~','Hardcover',49.99),
	('9780062437228','THAT''S WHAT SHE SAID:WHAT MEN AND WOMEN NEED TO KN','Lipman Joanne','Paperback',17.99),
	('9780310094012','NIV  PREMIUM GIFT BIBLE  LEATHERSOFT  PINK BROWN','~','Hardcover',19.99),
	('9780062911971','FREEFALL INTL:A NOVEL','Barry Jessica','Paperback',18.99),
	('9780310347644','KEEP SHOWING UP','Ehman Karen','Paperback',17.99),
	('9780062884299','AMERICAN DUCHESS:A NOVEL OF CONSUELO VANDERBILT','Harper Karen','Hardcover',26.99),
	('9781400208210','LIFE WITHOUT LACK','Willard Dallas','Paperback',16.99),
	('9780062081551','THE GRAVEYARD BOOK:A NOVEL','Gaiman Neil','Paperback',16.99),
	('9780062468901','THE WRONG HIGHLANDER:HIGHLAND BRIDES','Sands Lynsay','Ebook',7.99),
	('9780007554485','PARENT AGENCY THE','Baddiel, David','Paperback',6.99),
	('9780008200527','HEAD KID','Baddiel, David','Hardcover',0.00),
	('9780062836977','GOOD OMENS [TV TIE-IN]:THE NICE AND ACCURATE PROPH','Gaiman Neil','Mass Market',9.99),
	('9780062338082','THE VANISHING STAIR','Johnson Maureen','Hardcover',17.99),
	('9780310632191','CU NIV JOY OF EASTER  BAM','~','Paperback',4.95),
	('9780062880246','THE ENLIGHTENED CAPITALISTS:CAUTIONARY TALES OF BU','O''Toole James','Hardcover',35.00),
	('9781418542283','NASB  MACARTHUR STUDY BIBLE  LARGE PRINT  BONDED L','Macarthur John','Hardcover',89.99),
	('9780062890863','SHAZAM!: BECOMING SHAZAM','West Alexandra','Paperback',4.99),
	('9780062898630','SHAZAM!: A SHAZAM SHOWDOWN','West Alexandra','Paperback',4.99),
	('9780062875488','THE NIGHT AGENT:A NOVEL','Quirk Matthew','Ebook',21.99),
	('9780310453352','NIV  ARTISAN COLLECTION BIBLE  CLOTH OVER BOARD  T','~','Hardcover',49.99),
	('9781525823558','THE WOMAN IN THE LAKE','Cornick Nicola','Paperback',16.99),
	('9780007117307','CHRONICLES OF NARNIA THE','Lewis, C. S.','Paperback',19.99),
	('9780310621072','CU THOMPSON CHAIN REFERENCE BIBLE RVR 1960   HFCN','~','Other',64.99),
	('9780718039509','JESUS ALWAYS','Young Sarah','Hardcover',16.99),
	('9780062869852','DEATH IN PROVENCE:A NOVEL','Kent Serena','Hardcover',26.99),
	('9780062436641','TO DIE BUT ONCE:A MAISIE DOBBS NOVEL','Winspear Jacqueline','Paperback',16.99),
	('9781848799950','BIBLE STORIES FOR GIRLS','Ede Lara','Other',6.99),
	('9780008327255','CHALLENGE ACCEPTED!','Barber, Celeste','Hardcover',16.99),
	('9780062846884','A YEAR IN PARIS:SEASON BY SEASON IN THE CITY OF LI','Baxter John','Paperback',17.99),
	('9780007453580','DEMON DENTIST','Walliams, David','Paperback',6.99),
	('9780007477159','GAME OF THRONES: THE STORY CONTINUES A','Martin, George R.R.','Other',65.00),
	('9781400210046','THEFT OF AMERICAS SOUL','Robertson Phil','Hardcover',24.99),
	('9781591451884','JESUS CALLING','Young Sarah','Hardcover',16.99),
	('9780062667618','THAT KIND OF MOTHER:A NOVEL','Alam Rumaan','Paperback',16.99),
	('9781400205875','UNINVITED','Terkeurst Lysa','Paperback',17.99),
	('9781786928771','ART BOOKS EASTER ART','Make Believe Ideas','Hardcover',9.99),
	('9780062825612','WHERE OBLIVION LIVES','Frohock T','Paperback',16.99),
	('9780062371935','DEVIL''S DAUGHTER:THE RAVENELS MEET THE WALLFLOWERS','Kleypas Lisa','Mass Market',7.99),
	('9780062884657','THE RIGHT IT:WHY SO MANY IDEAS FAIL AND HOW TO MAK','Savoia Alberto','Hardcover',25.99),
	('9780008239336','DOCTOR''S KITCHEN: SUPERCHARGE YOUR HEALTH WITH 100','Aujla, Dr Rupy','Paperback',16.99),
	('9780008183424','GRANDPA''S GREAT ESCAPE','Walliams, David','Paperback',0.00),
	('9781335547743','FINDING FOREVER','Roberts Nora','Paperback',7.99),
	('9780008272111','BINDING THE','Collins, Bridget','Hardcover',12.99),
	('9780062684745','UNSHELTERED  EPB:A NOVEL','Kingsolver Barbara','Ebook',23.99),
	('9780310094029','NIV  PREMIUM GIFT BIBLE  LEATHERSOFT  BLACK GRAY','~','Hardcover',19.99),
	('9780062742469','HIDDEN FIGURES:THE TRUE STORY OF FOUR BLACK WOMEN','Shetterly Margot Lee','Hardcover',17.99),
	('9780062875679','NO EXIT:A NOVEL','Adams Taylor','Ebook',21.99),
	('9780062884343','THE HUNTRESS:A NOVEL','Quinn Kate','Hardcover',26.99),
	('9780008279752','GERONIMO','Walliams, David','Hardcover',12.99),
	('9780008304591','WORLD''S WORST CHILDREN 3 THE','Walliams, David','Hardcover',0.00),
	('9780062842619','DARWIN DEVOLVES:THE NEW SCIENCE ABOUT DNA THAT CHA','Behe Michael J','Hardcover',28.99),
	('9781400210947','ITS NOT SUPPOSED TO BE THIS WAY','Terkeurst Lysa','Digital Audio',18.99),
	('9780062393401','BIRD WATCH','Matheson Christie','Hardcover',17.99),
	('9781591451877','LOVE   RESPECT','Eggerichs Emerson','Hardcover',26.99),
	('9780310438922','NIV STUDY BIBLE  HARDCOVER  RED LETTER EDITION','~','Hardcover',49.99),
	('9780062457714','THE SUBTLE ART OF NOT GIVING A F*CK:A COUNTERINTUI','Manson Mark','Hardcover',24.99),
	('9780008241759','JOG ON','Mackie, Bella','Hardcover',12.99),
	('9780008200510','BIRTHDAY BOY','Baddiel, David','Paperback',6.99),
	('9780263275636','ITALIAN MAVERICKS: BOUND BY THE ITALIAN''S BARGAIN','Lee, Miranda','Paperback',7.99),
	('9781400318131','JESUS CALLING  LARGE PRINT LEATHERSOFT','Young Sarah','Hardcover',24.99),
	('9780062404312','PETE THE CAT AND THE TIP-TOP TREE HOUSE','Dean James','Paperback',4.99),
	('9780062906533','THE NEXT TO DIE:A NOVEL','Hannah Sophie','Paperback',18.99),
	('9780062564559','MAHIMATA','Mehrotra Rati','Paperback',16.99),
	('9780718086107','INDESCRIBABLE','Giglio Louie','Hardcover',17.99),
	('9780007554546','PERSON CONTROLLER THE','Baddiel, David','Paperback',0.00),
	('9781335942432','ENAMORED  CLAIM ME COWBOY','Palmer Diana','Paperback',7.99),
	('9780718091385','NEHEMIAH CODE','Hawkins O S','Hardcover',14.99),
	('9780062867469','LADY DERRING TAKES A LOVER:THE PALACE OF ROGUES','Long Julie Anne','Mass Market',7.99),
	('9780062795908','NO SUNSCREEN FOR THE DEAD:A NOVEL','Dorsey Tim','Ebook',21.99),
	('9780263273342','VIRGIN TO REDEEM THE BILLIONAIRE A','Collins, Dani','Paperback',5.99),
	('9780263273335','HEIRESS''S PREGNANCY SCANDAL','James, Julia','Paperback',5.99),
	('9780008262907','BOSH!','Firth, Henry','Hardcover',20.00),
	('9780008261252','DARK PATH THE','Sacks, Michelle','Paperback',7.99),
	('9780062405661','VIETNAM:AN EPIC TRAGEDY, 1945-1975','Hastings Max','Hardcover',37.50),
	('9780062675187','PETE THE CAT AND THE LOST TOOTH','Dean James','Paperback',4.99),
	('9780310094050','NIV  PREMIUM GIFT BIBLE  LEATHERSOFT  TEAL  RED LE','~','Hardcover',19.99),
	('9780060936426','THE FORGOTTEN MAN:A NEW HISTORY OF THE GREAT DEPRE','Shlaes Amity','Paperback',15.99),
	('9780062839091','THE QUINTLAND SISTERS:A NOVEL','Wood Shelley','Paperback',15.99),
	('9780060899226','KITCHEN CONFIDENTIAL UPDATED ED:ADVENTURES IN THE','Bourdain Anthony','Paperback',16.99),
	('9780062383020','MONKEY TIME','Hall Michael','Hardcover',17.99),
	('9780778307945','CHANGING HABITS','Macomber Debbie','Paperback',7.99),
	('9780718078133','EVERYBODY  ALWAYS','Goff Bob','Paperback',16.99)
)

AS [S] ([ISBN],[Title], [Author], [Format], [ListPrice])

ON [T].[ISBN] = [S].[ISBN]

WHEN MATCHED AND [T].[Title] <> [S].[Title] THEN
	UPDATE SET [Title] = [S].[Title]

WHEN MATCHED AND [T].[Author] <> [S].[Author] THEN
	UPDATE SET [Author] = [S].[Author]

WHEN MATCHED AND [T].[Format] <> [S].[Format] THEN
	UPDATE SET [Format] = [S].[Format]

WHEN MATCHED AND [T].[ListPrice] <> [S].[ListPrice] THEN
	UPDATE SET [ListPrice] = [S].[ListPrice]


WHEN NOT MATCHED THEN
	INSERT ([ISBN],[Title], [Author], [Format], [ListPrice])
	VALUES ([S].[ISBN],[S].[Title], [S].[Author], [S].[Format], [S].[ListPrice])

WHEN NOT MATCHED BY SOURCE THEN
	DELETE;