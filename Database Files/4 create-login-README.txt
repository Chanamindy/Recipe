script to create login and user is exluded from this repo.
Create a file called create-login.sql (this file is ignored by git ignore in this repo)
add the following script to that file

--IMPORTANT create login in MASTER
--use MASTER
create login [loginname] with password = '[password]'

--IMPORTANT switch to RecipeWebsiteDB
--use RecipeWebsiteDB
create user [username] from login [loginname] 