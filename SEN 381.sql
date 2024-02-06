create database StudentRegistrationSystemforBelgiumCampus
go
drop database StudentRegistrationSystemforBelgiumCampus

use StudentRegistrationSystemforBelgiumCampus

create table Students
(   
    stuID int primary key,
    firstName varchar(30),
    lastName varchar(30),
    courseID int, 
    foreign key (courseID) references Course(courseID)
);
drop table Course

create table Course
(   
    courseID int primary key,
    CourseCode varchar(30)
);
insert into course (courseid, coursecode) values
(1, 'SEN381'),
(2, 'MAT281'),
(3, 'LPR381');
insert into students (stuid, firstname, lastname, courseid) values
(101, 'Miles', 'Moyo', 1),
(102, 'Jane', 'Tayiya', 2), 
(103, 'Sibusiso', 'Skosana', 1); 

create procedure spStudents
as
begin
    select * from Students;
end;

exec spStudents

create procedure spSearchStudent
    @firstname varchar(30)
as
begin
    select *from Students
    where firstname = @firstname;
end;

exec spSearchStudent
