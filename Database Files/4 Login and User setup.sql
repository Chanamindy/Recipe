--replace //loginname// and //password// with secret values from vault
--IMPORTANT create login in MASTER
--use master
create login //loginname// with PASSWORD = '//password//'

--important switch to RecipeWebsiteDB
create user cpudev_user from login //loginname// 

alter role db_datareader add member cpudev_user 
alter role db_datawriter add member cpudev_user 