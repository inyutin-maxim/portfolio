DROP TABLE "dynamic_page";

CREATE TABLE "dynamic_page" (
	"id" INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	"alias" NVARCHAR(50) NOT NULL,
	"title" NVARCHAR(120) NOT NULL,
	"content" TEXT NOT NULL,
	"parent_id" INT NOT NULL DEFAULT(0),
	"create_date" DATE NOT NULL,
	"visible" BIT NOT NULL DEFAULT(1),
	"deleted" BIT NOT NULL DEFAULT(0)
)