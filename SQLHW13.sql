select * from dbo.Students
select*from dbo.Classes
select*from dbo.Scores

insert into dbo.Students(FirstName,LastName,SSN,Address,City, State, Zip, Phone)
values					('Alfonso', 'Margarita', 847, '2343 Snope Ct.', 'Houston', 'Texas', 74734, 111)

insert into dbo.Classes(Title,Number,Department)
Values					('Fencing', 877, 'PE')

insert into dbo.Scores(Type, Description, DateAssigned, DateDue, DateSubmitted, PointsEarned, PointsPossible)
values                ('Quiz', 'Pop Quiz One', 2019-05-16, 2019-05-16, 2019-05-16, 7,10)

