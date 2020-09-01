# BLOGME
BLOG(.NET CORE)



README- BLOGGER
A-Technology-design and implementations:
The blogger app is created with asp.net mvc core technology.  

![Image of 1](https://github.com/fkbeys/BLOGME/blob/master/BLOGGER_FETHULLAHKAYA/IMG/1.png?raw=true)

As you see on the above picture, the app has 2 Controllers as Articles and Authors. To demonstrate the usage and benefits of Repository pattern, the Author controller reaches out the database directly with the Database Context class.  In the future, if we would make some changes or maintenance, we had to work too much. Whereas in the Articles Controllers, we get the database context through with repository class which interfaced from IRepostory class. In the future, if we would alter database or make some changes, it will be easier. And it will be easy to change for anybody too.
	On the other hand, when we start the app, the Database Context gets instance one time. And each database operation is held with it. To improve performance, it’s necessary and this principle is described as singleton principle.
Note: The database context gets the connection string while startup. 
 
 ![Image of 2](https://github.com/fkbeys/BLOGME/blob/master/BLOGGER_FETHULLAHKAYA/IMG/2.png?raw=true)

HOW TO USE THE BLOGGER APP


The database designed as Microsoft Sql Server. The table creation scripts are below. But before please create a database named as BLOGME  
The Entity Framework will create the Database if you run the Update-Database in console .
Otherview, the database designed as below
 ![Image of 3](https://github.com/fkbeys/BLOGME/blob/master/BLOGGER_FETHULLAHKAYA/IMG/3.png?raw=true)


1-Create the ARTICLES TABLE
```
CREATE TABLE [dbo].[ARTICLES](
	[ARTICLE_ID] [int] IDENTITY(1,1) NOT NULL,
	[ARTICLE_AUTHOR_ID] [int] NULL,
	[ARTICLE_CREATE_DATE] [date] NULL,
	[ARTICLE_EDIT_AUTHOR_ID] [int] NULL,
	[ARTICLE_EDIT_DATE] [date] NULL,
	[ARTICLE_TITLE] [nvarchar](50) NULL,
	[ARTICLE_IMAGEURL] [nvarchar](max) NULL,
	[ARTICLE_DESCRIPTION] [nvarchar](max) NULL,
	[ARTICLE_CONTENT] [nvarchar](max) NULL,
	[ARTICLE_ISACTIVE] [bit] NULL,
	[ARTICLE_LIKE] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
```
2- Create the AUTHORS TABLE

```
CREATE TABLE [dbo].[AUTHORS](
	[AUTOHOR_ID] [int] IDENTITY(1,1) NOT NULL,
	[AUTHOR_NAME] [nvarchar](30) NULL,
	[AUTHOR_SURNAME] [nvarchar](30) NULL,
	[AUTHOR_CREATE_DATE] [datetime] NULL,
	[AUTHOR_ISACTIVE] [bit] NULL,
 CONSTRAINT [PK_AUTHORS] PRIMARY KEY CLUSTERED 
(
	[AUTOHOR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AUTHORS] ADD  CONSTRAINT [DF_AUTHORS_AUTHOR_CREATE_DATE]  DEFAULT (getdate()) FOR [AUTHOR_CREATE_DATE]
GO
```
HOW TO USE

In the Articles Controller. The blogger app has 5 operations as List, Find, Add, Change and Delete.  To call the methods, we need an app as Postman etc.  The route is localhost+ port + api + controller name. As example http://localhost:1600/api/Articles. 

GET: http://localhost:1600/API/ARTICLES
GET: http://localhost:1600/API/ARTICLES/1

PUT: http://localhost:1600/API/ARTICLES/1    
RAW DATA 
{
    "articlE_ID": 1,    "articlE_AUTHOR_ID": 1,     "articlE_CREATE_DATE": "2019-11-11T00:00:00",
    "articlE_EDIT_AUTHOR_ID": 1,    "articlE_EDIT_DATE": "2018-10-10T00:00:00",
    "articlE_TITLE": "PUT TEST",    "articlE_IMAGEURL": "PUT TEST",    "articlE_DESCRIPTION": "PUT TEST",    
    "articlE_CONTENT": "PUT TEST",    "articlE_ISACTIVE": true,    "articlE_LIKE": 11
}

POST: http://localhost:1600/API/ARTICLES
RAW DATA 
{    "authoR_NAME": "zzz ",    "authoR_SURNAME": "zzz"   }

DELETE: http://localhost:1600/API/ARTICLES/4 




If i would extend the project, i would add  a swagger library for helping developers to understand the project better. 
Also it s mandatory to add an authentication controller to secure the app.
In addition, i would use stored procedures for update and insert, views for listing, Table or scalar functions for find operations.
