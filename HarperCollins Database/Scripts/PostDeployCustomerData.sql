﻿MERGE [CustomerData] AS [T]
USING 
(
	VALUES (10329754,'BARNES & NOBLE DISTRIBUTION','ATTN JOHN PICKFORD','DEPT 1709011','PO BOX 1843'),
	(10326871,'READERLINK DISTRIBUTION SERVICES LLC','ACCOUNTS PAYABLE DEPT','1420 KENSINGTON RD STE 300','~'),
(18015488,'BN FINANCIAL CTR EBK','ATTN BN.COM MERCHANDISE PAYABL','PO BOX 1843','~'),
(10307927,'AMAZON.COM KYDC INC','ACCOUNTS PAYABLE','PO BOX 80387','~'),
(10305592,'AMAZON.COM INC','ACCOUNTS PAYABLE','PO BOX 80387','~'),
(10301359,'AMERICAN WHOLESALE BOOK CO','TRADE PAYABLE','PO BOX 190308','~'),
(10330746,'INGRAM BOOK CO','ACCTS PAYABLE 366','ONE INGRAM BLVD','PO BOX 3006'),
(10901323,'TESCO STORES LTD','OAKWOOD DISTRIBUTION GREAT BAN','WINGATES IND PARK','~'),
(10903536,'PCS BOOKS LTD','UNIT 5 VULCAN HOUSE','VULCAN ROAD','~'),
(10906783,'ASDA STORES LIMITED','ROCKINGHAM WAY','REDHOUSE INTERCHANGE','~'),
(10947456,'AMZ COVENTRY BHX4','PLOT 1, LYONS PARK','COUNDON WEDGE DRIVE, BROWNS LA','~'),
(10330002,'CHRISTIAN BOOK DISTRIBUTORS','ACCOUNTS PAYABLE','PO BOX 6000','~'),
(10332531,'BARNES & NOBLE INC','ATTN JOHN PICKFORD','PO BOX 1843','1400 OLD COUNTRY ROAD'),
(10326902,'BAKER & TAYLOR CO','ACCOUNTS PAYABLE','2550 W TYVOLA RD STE 400','~'),
(10001646,'COSTCO WHOLESALE CANADA LTD.','VENDOR 53406-00  A/P','999 LAKE DR','~'),
(10313309,'OVERDRIVE EBK','E BOOK ACCOUNT','8555 SWEET VALLEY DRIVE STE A','~'),
(10329566,'HUDSON NEWS CO','ATTN:  HASENA HURLEY','701 JEFFERSON RD','~'),
(10910718,'HARPERCOLLINS AUSTRALIA','YARRAWA ROAD','MOSS VALE','~'),
(10307418,'HUDSON RPM DISTRIBUTORS LLC R','8 COTTON RD','~','~'),
(10329447,'BOOKAZINE CO INC','Loose Receiving','75 HOOK RD','~'),
(10614326,'TURNING POINT FOR GOD','10007 RIVERFORD RD','~','~'),
(18390000,'HCP FOSINA','HARPERCOLLINS PUBLISHERS','53 GLENMAURA NATIONAL BLVD','~'),
(10000376,'INDIGO BOOKS & MUSIC MAIL','100 ALFRED KUEHNE BLVD BLD 55','ATTN: ACCOUNTS PAYABLE','~'),
(18249810,'HARPERCOLLINS MEXICO SA DE CV','CONSIGNMENT MATERIAL','TAMPICO 42 6TO PISO','~'),
(10620561,'BOOK DEPOT REMAINDER ONLY','REMAINDER ONLY','2299 KENMORE AVE','~'),
(10613037,'PASTORS.COM','23182 ARROYO VISTA','~','~'),
(10903627,'GARDNERS BOOKS LIMITED','1 WHITTLE DRIVE','WILLINGDON DROVE','~'),
(10617892,'OM BOOKS FOUNDATION','LOGOS BHAVAN','JEEDIMETLA VILLAGE','MEDCHAL RD'),
(18151945,'HARVEST CHRISTIAN FELLOWSHIP','HARVEST RESOURCES','6115 ARLINGTON AVE','~'),
(10903915,'AMZ TILBURY LCY2','UNIT 2, LONDON DISTRIBUTION PA','WINDRUSH ROAD','~'),
(10903931,'AMZ WARRINGTON MAN2','OMEGA PLOT 7C','ORION BOULEVARD, GREAT SANKEY','~'),
(10903899,'AMZ DUNSTABLE LTN4','UNIT DC1 (PROLOGIS)','BOSCOMBE ROAD','~'),
(10905059,'W H SMITH HIGH STREET LTD','GREENBRIDGE IND ESTATE','GREENBRIDGE ROAD','~'),
(10617053,'GRACE TO YOU','P O BOX 4000','~','~'),
(18108706,'RECORDED BOOKS EBK','270 SKIPJACK RD','~','~'),
(10947462,'AMZ BOLTON MAN3','BRIDGEWATER AVENUE','.','~'),
(10329348,'COWLEY DISTRIBUTING INC','DBA THE NEWS GROUP','732 HEISINGER RD','~'),
(10908059,'SBS - SPECIAL BOOK SERVICES LI','RUA EDUARDO LEOPOLDO, 414/420','.','~'),
(10800907,'INDIGO BOOKS & MUSIC INC VMI','100 Alfred Kuehne Blvd','BUILDING 55','VENDOR 706848 VMI'),
(10906442,'WHS TRAVEL (SWINDON)','GREENBRIDGE IND ESTATE','GREENBRIDGE ROAD','~'),
(10903907,'AMZ MANCHESTER MAN1','6 SUNBANK LANE, AIRPORT CITY','MANCHESTER','~'),
(10337745,'AMAZON EU SARL','UK BRANCH','1 PRINCIPAL PL WORSHIP ST','VAT NUMBER GB 727255821'),
(18219671,'B I LTD EBK','21 LAFFAN ST','~','~'),
(10331228,'MARY KAY COSMETICS INC','ACCOUNTS PAYABLE','16251 DALLAS PKWY','~'),
(10901119,'THE BOOK DEPOSITORY LTD','UNIT 5, DAVY WAY','HARDWICKE','~'),
(10326600,'BOUND TO STAY BOUND BOOKS INC','1880 WEST MORTON RD','~','~'),
(10904175,'GDL  MORR','UNIT 3, 21/25 EDISON RD','HIGHFIELD IND ESTATE','~'),
(10617558,'KOORONG BOOKS PTY LTD','28 W PARADE','~','~'),
(10913263,'HARPER ENT (AUSTRALIA)','55 Yarrawa Road','.','~'),
(10326167,'HERTZBERG NEW METHOD','617 EAST VANDALIA RD','USE 191127 FOR DRPSHP/RUSHORD','~'),
(10911123,'MEDIA 24 PTY T/A (JONATHAN BAL','66 MIMETES ROAD','DENVER EXT. 9','~'),
(10620509,'JOHN MAXWELL LLC','STE 195','2170 SATELLITE BLVD','~'),
(10000963,'METRO NEWS CMMI CALGARY','120 SINNOTT ROAD','C/O METRO NEWS   A/P MANAGER','~'),
(10613985,'BIBLES BY THE CASE','5753 E SANTA ANA CYN RD 634','~','~'),
(10332833,'UNITED METHODIST PUBLISH HOUSE','2222 ROSA L PARKS BLVD','~','~'),
(10330132,'HARRISBURG NEWS AGENCY','711 GIBSON BLVD','~','~'),
(18242252,'BIBLES IN BULK','140 SUMMIT ST','~','~'),
(10618317,'LUCIANO BOOKSTORE DISTRIBUTOR','LUCIANO RODRIGUEZ','4450 NW 135 ST','~'),
(10903929,'AMZ DORTMUND DTM2','KALTBANDSTRASSE 4','44145 DORTMUND','~'),
(10903800,'AMAZON EU SARL, UK BRANCH','1 PRINCIPAL PLACE','WORSHIP STREET','~'),
(10332418,'CHOICE BOOKS','963 RESERVOIR ST','STE 200','~'),
(10330400,'BOOKSOURCE','1230 MACKLIND AVE','~','~'),
(10000737,'UNITED LIBRARY SERVICES INC','7140 FAIRMOUNT DRIVE S.E.','~','~'),
(18291019,'AMAZON EU SARL','38 AVE JOHN F KENNEDY','~','~'),
(10911124,'MEDIA 24 PTY T/A (JONATHAN BAL','66 MIMETES ROAD','DENVER EXT. 9','~'),
(18285555,'RESCUE HOUSE CHURCH','653 WILKESBORO ST','~','~'),
(18093902,'CHURCHSOURCE WEB TAX CC SHOPIFY','3900 SPARKS DR SE','~','~'),
(10907363,'WATERSTONE''S BOOK HUB CAMPAIGN','FIFTH AVENUE','CENTRUM 100','~'),
(10913265,'CENGAGE LEARNING','MAILSTOP 09','5191 NATORP BLVD,','~'),
(10907595,'WATERSTONE''S BOOK HUB -MEZZANI','FIFTH AVENUE','CENTRUM 100','~'),
(10910691,'MPH DIST(S)PTE LTD','HABITAT WAREHOUSE,','12 TAGORE DRIVE, LEVEL 3','~'),
(10305802,'CHILDRENS PLUS INC','PO BOX 847','~','~'),
(18093904,'CHURCHSOURCE WEB TAX EXEMP CC SHOPIFY','3900 SPARKS DR SE','~','~'),
(10334530,'HARPERCOLLINS PUB AUSTRALIA','ATTN SOPHIE ZHU','201 ELIZABETH ST','~'),
(10312484,'LIBRI GMBH','EUROPAALLEE 1','~','~'),
(10332116,'BENJAMIN NEWS GROUP MISSOULA','PO BOX 16147','1701 RANKIN','~'),
(10334341,'BRO DART COMPANY','ATTN: VIOLET BANGHART','500 ARCH ST 4-N','~'),
(10913159,'DTC HOME CONTINUITY ORDERS','WESTERHILL ROAD','BISHOPBRIGGS','~'),
(10301537,'RPBS LLC','PO BOX 720728','~','~'),
(10614913,'JESUS FIRST PARABLE CHRISTIAN','675 US 1 S','~','~'),
(10903868,'AMZ HERTFORDSHIRE LTN2','BOUNDARY WAY','HEMEL HEMPSTEAD','~'),
(10903824,'AMZ GOUROCK GLA1','2 CLOCH ROAD','FAULDS PARK','~'),
(10906177,'BERTRAM TRADING LTD','BROADLAND BUSINESS PARK','~','~'),
(10328882,'VALLEY NEWS CO','1305 STADIUM RD','~','~'),
(10903828,'AMZ PETERBOROUGH EUK5','PHASE TWO, KINGSTON PARK','FLAXLEY ROAD','~'),
(10927801,'MONTGOMERY CO JUNIOR','SCHOOL HOUSE','BARONSWOOD WAY','~'),
(18270419,'VITALSOURCE TECHNOLOGIES LLC EBK','ONE INGRAM BLVD','~','~'),
(10330509,'BARNES & NOBLE COLLEGE','STATEMENT ACCOUNT FOR ORDERS','COLLEGE  DIV.-CRED DEPT USE','120 MOUNTAIN VIEW BOULEVARD'),
(18150785,'HCCP SPECIALTY BLOCK ACCT KD','501 NELSON PL','~','~'),
(10903822,'AMZ RIDGMONT LTN1','PLOT 8','MARSTON GATE FULFILLMENT CENTR','~'),
(10959688,'AMZ PETERBOROUGH EUKB','UNIT 12, OVERTON PARK','ORTON SOUTHGATE','~'),
(10714354,'STRUIK CHRISTIAN MEDIA PTY LIMITED','PO BOX 3434','TYGERVALLEY','BELLVILLE'),
(10900581,'LOMOND BOOKS LTD','UNIT 14 FRESKYN PLACE','EAST MAINS INDUSTRIAL ESTATE','~'),
(10903832,'AMZ RUGELEY BHX1','TOWERS BUSINESS PARK','POWER STATION ROAD','~'),
(10306407,'COMPLETE BOOK AND MEDIA SUPPLY -R-','1200 TORO GRANDE DR STE 200','~','~'),
(18134179,'GUIDESTONE FINANCIAL SBC','5005 LBJ FREEWAY STE 2200','~','~'),
(18080281,'SUPERIOR TEXT LLC  SM','151 AIRPORT INDUSTRIAL DR','~','~'),
(10001006,'RAINCOAST BOOKS/BOOK EXPRESS','2440 VIKING WAY','~','~'),
(18259475,'LIBRARY IDEAS','PO BOX 9','~','~'),
(10328944,'MACKIN LIBRARY MEDIA','3505 COUNTY ROAD 42 W','~','~'),
(10001695,'LIBRARY BOUND INC.','100 BATHURST DRIVE','UNIT 2','~'),
(10324766,'BRAZOS BOOKSTORE','2421 BISSONNET ST','~','~'),
(10309415,'EVERY CHILD SUCCEEDS','3333 BURNET AVE','ML 3005','~'),
(10903889,'AMZ DUNFERMLINE EDI4','AMAZON WAY','.','~'),
(10913496,'ADLIBRIS GROSSIT','ADLIBRISVAGEN 1','MORGONGAVA','~'),
(18122702,'GIVINGTONS SM','2209 HAWKS LANDING','~','~'),
(10904075,'A GREAT READ LTD','UNIT 3, WOODLAND INDUSTRIAL ES','.','~'),
(10327767,'TEXTBOOK WAREHOUSE','936 CURIE DR','~','~'),
(10327450,'MORNING STAR CHR BOOKS AND MUSIC','375 HARVARD ST','~','~'),
(10305989,'TODD COMMUNICATIONS INC','STE 102','611 E 12TH AVE','~'),
(18093893,'CHURCHSOURCE TAXABLE','STE 300','53 GLENMAURA NAT''L BLVD','~'),
(10931840,'ST ANNES PRIMARY SCHOOL','PRESCOT ROAD','OLD SWAN','~'),
(10905058,'W H SMITH HIGH STREET LTD','(BOUGHT OUT A/C)','GREENBRIDGE ROAD','~'),
(18067331,'LIGONIER MINISTRIES','421 LIGONIER CT','~','~'),
(10900796,'EDEN.CO.UK','UNIT 5 GLENDALE AVENUE','SANDYCROFT','~'),
(18175280,'FUTURESOFT INC EBK','STE E','1660 TOWNHURST DR','~'),
(18074557,'ZULILY  SM','2601 ELLIOTT AVE','~','~'),
(18098492,'CLASSROOM LIBRARY COMPANY','3901 UNION BLVD STE 155','~','~'),
(10903203,'NEWSPREAD','UNIT S1 LE BROCQUY AVENUE','PARKWEST IND ESTATE, CLONDALKI','~'),
(10903901,'AMZ DUNSTABLE LTN4','UNIT DC1 (PROLOGIS)','BOSCOMBE ROAD','~'),
(10910487,'SINO COMMERCIAL TRADING CO','12TH FLOOR, HUA DI BUSINESS CE','.','~'),
(18129924,'HCCP WEB ORDERS SHOPIFY','501 NELSON PLACE','~','~'),
(10902098,'SANDPIPER','C/O ALTON LOGISTICS ALTON LOGI','UNIT 4','~'),
(10305554,'NBC UNIVERSAL','NBC RETAIL OPERATIONS','30 ROCKEFELLER PLZ STE 1009W 3','~'),
(10912493,'CHINA NATIONAL PUBLICATIONS IM','GUANGZHOU BRANCH','25 DAJIANGCHONG XIN GANG XI RO','~'),
(10616065,'GRASON WORLD WIDE PUBLICATIONS','ATTN ACCOUNTS PAYABLE','PO BOX 668129','~'),
(10936873,'HOUNSLOW TOWN PRIMARY SCHOOL','PEARS ROAD','HOUNSLOW','~'),
(10335093,'ROCKY RIDGE BOOKSTORE','ATTN KAY SCOTT','3060 HWY A','~'),
(10003078,'AMAZON.CA--A/P VENDOR 654728','P.O.BOX 80486','~','~'),
(18074627,'KOCH NEFF AND VOLCKMAR GMBH','INDUSTRIESTR 23','~','~'),
(10326738,'WW WICKEL CO BOOK FAIRS','520 N EXCHANGE CT','~','~'),
(10332433,'LIFEWAY CHRISTIAN RESOURCES','ATTN: RETAIL A/P MSN 133','ONE LIFE WAY PLAZA','~'),
(10911652,'(LIBRI GMBH, BAD HERSFELD) IBS','LIBRI GMBH','EUROPAALLEE 1','~'),
(10335077,'B V VAN DITMAR BOEKENIMPORT','JOOP GEESINKWEG 901','~','~'),
(10316664,'WEBSEW.COM INC','22C CRAGWOOD RD','~','~'),
(10334225,'JONATHAN BALL PUBLISHERS','PO BOX 33977','~','~'),
(10307963,'EXCELLIGENCE LEARNING CORP','DBA DISCOUNT SCHOOL SUPPLY','20 RYAN RANCH RD STE 200','~'),
(10314956,'POLITICS & PROSE','BOOKSTORE','5015 CONNECTICUT AVE NW','~'),
(18295894,'ELEVATE CHURCH','23486 DEER PATH TRAIL','~','~'),
(10321954,'BOOKS & BOOKS INC -R-','265 Aragon Avenue','~','~'),
(10301248,'EL MONTE UN H S DIST','3537 N JOHNSON AVE','~','~'),
(10911226,'MESSINTER S.P.A.','VIA CAMPANIA N. 12  SAN GIULIA','.','~'),
(10334374,'BAKER BOOK HOUSE','PO BOX 6287','~','~'),
(10910687,'MPH DIST(S) PTE LTD','5, JALAN BERSATU, SECTION 13/4','PETALING JAYA','~'),
(10701905,'REV ROBERT J MORGAN','AUTHOR ACCOUNT','DONELSON FREE WILL BAPT','3210 MCGAVOCK PIKE'),
(10620575,'JR BLUE LABEL MANAGEMENT','PO BOX 3110','~','~'),
(10326474,'FOLLETT LIBRARY RESOURCES','ATTN:PURCHASING DEPT','1340 RIDGEVIEW DR','~'),
(10911658,'KOCH,NEFF & VOLCKMAR GMBH (ERF','KNV BOOK WHOLESALE, TN 31000','FERDINAND-JUEHLKE-STR. 7','~'),
(10935387,'THORNDON C E PRIMARY SCHOOL','THE STREET','THORNDON   EYE','~'),
(18103489,'BOOKAZINE INTL CO INC','INTL CONSUMER DIRECT FULFILMEN','75 HOOK RD','~'),
(18017141,'ALL BIBLES LLC','10810 N HARRISON ST','~','~'),
(10309569,'800 CEO READ','544 S1ST ST','~','~'),
(10902270,'HYMNS ANCIENT & MODERN LTD','13A HELLESDON PARK ROAD','DRAYTON HIGH ROAD','~'),
(10383791,'READ TO THEM INC SM','2201 W BROAD ST STE 206','~','~'),
(10334396,'CRACKER BARREL SM','ATTN: WAREHOUSE','HARTMAN DRIVE','PO BOX 787'),
(10908652,'UNIVERSITY BOOKSHOP','KING FAISAL ST, PO BOX 30965','.','~'),
(10937197,'MULBERRY PRIMARY SCHOOL','PARKHURST ROAD','TOTTENHAM','~'),
(18239055,'HARPERCOLLINS FRANCE RETAIL INTL','83 85 BOULEVARD VINCENT AURIOL','CEDEX 13','~'),
(10903582,'PRICE CUT BOOKS LTD T/A LOWPLE','UNIT 31 VULCAN HOUSE BUSINESS','VULCAN ROAD','~'),
(10001607,'NORTH 49 BOOKS','35 PRINCE ANDREW PLACE','~','~'),
(10908421,'PRO FORMA ACCOUNTS GLA','C/O CUSTOMER SERVICE DEPT HARP','WESTERHILL ROAD BISHOPBRIGGS','~'),
(10616497,'CORNERSTONE BOOKSTORE','1894 BLOWING ROCK RD','~','~'),
(10955494,'AMZ WARRINGTON EUKD','FOUNDRY POINT HALEBANK','INDUSTRIAL ESTATE FOUNDRY LANE','~'),
(10307231,'HARPER ENTERPRISE PREMIUM NONRETURNABLE','PREMIUM  NONRETURNABLE','53 GLENMAURA NATIONAL BLVD STE','~'),
(10001035,'MONAHAN AGENCY - CMMI VERNON NORTH','2506-41ST STREET','~','~'),
(10000955,'BLACK BOND BOOKS BC','15562 24TH AVENUE, UNIT 1','~','~'),
(10933753,'SANDON  PRIMARY SCHOOL','NORMACOT GRANGE ROAD','MEIR','~'),
(18090374,'WIND CITY BOOKS LLC','152 S CENTER ST','~','~'),
(18160462,'PARTNER ID','7 A STAROPETROVSKY PR D','~','~'),
(10908085,'AUDIO VISUAL CENTRE LTD','MAYFLOWER MANSIONS PO BOX 58','BISAZZA STREET','~'),
(10616391,'BIBLICA','1820 JET STREAM DR','~','~'),
(10910128,'TONGBANG PUBLICATION INC.','B 102 SK TECHNO BUILDING SEONG','.','~'),
(10901251,'LUDLOW BOOKS','BARRACKS FARM','LOWER HAYTON','~'),
(10909311,'KINOKUNIYA BOOKSHOP LLC','W/H NO # 12 , B BLOCK , 6TH ST','P.O BOX 31929 , DUBAI','~'),
(10320005,'COMPASSION INTERNATIONAL','12290 VOYAGER PKWY','~','~'),
(10910669,'ASIA BOOKS COMPANY LIMITED.','BERLI JUCKER HOUSE, 14TH FLOOR','PRAKANONG, KLONGTOEY,','~'),
(10325192,'AL MAYA GLOBAL LLC','PO BOX 8476','PORT SAEED PRINTING PRESS BLDG','AIRPORT RD AL GARHOUD'),
(10000490,'JACK THE BOOKMAN LTD','1150 KERRISDALE BLVD UNIT 4','~','~'),
(10000411,'WHITEHOTS INC','205 Industrial Parkway North','UNIT #3','~'),
(10328584,'BARSTONS CHILDS PLAY','7156 AMBASSADOR RD','~','~'),
(10000576,'LIBRARY SERVICES CENTRE','131 SHOEMAKER STREET','~','~'),
(10905061,'WH SMITH HIGH ST LTD ADD B/O','BACKLIST   BOUGHT OUT A/C','GREENBRIDGE ROAD','~'),
(10307179,'BRAVO LTD','59 HUTTON GROVE','~','~'),
(10909980,'(FOR VAN DITMAR AMSTERDAM)','AUDAX MEDIA LOGISTICS, TEAM ON','BURGEMEESTER KROLLAAN 14','~'),
(10908149,'MILLER DISTRIBUTORS LTD','MILLER HOUSE TARXIEN ROAD AIRP','LUQA  P.O. BOX 25','~'),
(10942616,'ST RICHARDS CATHOLIC COLLEGE','ASHDOWN ROAD','BEXHILL-ON-SEA','~'),
(10308304,'TATTERED COVER -R-','USE 207149','2526 E COLFAX AVE','~'),
(10910082,'MARUZEN CO.,LTD.','PO BOX 671, GINZA BRANCH','.','~'),
(10339984,'BOOKPAL LLC SM','18101 VON KARMAN AVE STE 120','~','~'),
(18193917,'SOA RETAIL (CDN TO US)','2 BLOOR ST E 20TH FL','~','~'),
(10315104,'SKETCH BOOKS INC','STALL NO 301 R3 LEVEL POWER PL','ROCKWELL CENTER','~'),
(10960263,'BLYTH ACADEMY FLORENCE SRL','VIA JACOPO NARDI 18','FLORENCE','~'),
(10315641,'METROMEDIA ENTERTAINMENT','PO BOX 5188','~','~'),
(10900628,'RHODAWN LTD T/A BOOKSPEED','16 SALAMANDER YARDS','~','~'),
(10327249,'FOLLETT HEG RETAIL SERVICES','ACCTS PAYABLE DEPT','PO BOX 3488','~'),
(10302009,'KENS EDUCATIONAL JOYS','1930 DIVISION HWY','~','~'),
(18104901,'KOORONG BOOKS PTY LTD EBK','28 WEST PARADE','WEST RYDE','~'),
(10913160,'DTC HOME INSHIPMENT ORDERS','WESTERHILL ROAD','BISHOPBRIGGS','~'),
(10903878,'AMZ LAUWIN LIL1','5 RUE PLAETIS LUXEMBOURG C/O A','1 RUE AMAZON, 59 553 LAUWIN PL','~'),
(10911653,'(LIBRI GMBH SONDERAUFTRAG, GER','LIBRI GMBH SONDERAUFTRAG','SONDERAUFTRAG WARENEINGANG, EU','~')


) AS [S] ([CustomerNumber],[CustomerName], [AddressLine1], [AddressLine2], [AddressLine3])
ON [T].[CustomerNumber] = [S].[CustomerNumber]

WHEN MATCHED AND [T].[CustomerName] <> [S].[CustomerName] THEN
	UPDATE SET [CustomerName] = [S].[CustomerName]

WHEN MATCHED AND [T].[AddressLine1] <> [S].[AddressLine1] THEN
	UPDATE SET [AddressLine1] = [S].[AddressLine1]

WHEN MATCHED AND [T].[AddressLine2] <> [S].[AddressLine2] THEN
	UPDATE SET [AddressLine2] = [S].[AddressLine2]

WHEN MATCHED AND [T].[AddressLine3] <> [S].[AddressLine3] THEN
	UPDATE SET [AddressLine3] = [S].[AddressLine3]


WHEN NOT MATCHED THEN
	INSERT ([CustomerNumber],[CustomerName], [AddressLine1], [AddressLine2], [AddressLine3])
	VALUES ([S].[CustomerNumber],[S].[CustomerName], [S].[AddressLine1], [S].[AddressLine2], [S].[AddressLine3])

WHEN NOT MATCHED BY SOURCE THEN
	DELETE;