create table tst ( Id int not null auto_increment primary key, name char(32), surname char(48), phones tinytext );

insert into tst set name="alex", surname="barski", phones="203";
