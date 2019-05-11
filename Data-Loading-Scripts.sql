USE [CodingChallengeGRS]

INSERT [dbo].[Projects]([StartDate], [EndDate], [Credits])
VALUES ('5/14/2018 10:30:00 AM', '1/30/2019 6:00:00 PM', 5000)

INSERT [dbo].[Projects]([StartDate], [EndDate], [Credits])
VALUES ('3/14/2018 10:30:00 AM', '1/30/2019 6:00:00 PM', 7000)

INSERT [dbo].[Projects]([StartDate], [EndDate], [Credits])
VALUES ('8/1/2018 8:30:00 AM', '10/15/2019 7:00:00 PM', 10000)

INSERT [dbo].[Projects]([StartDate], [EndDate], [Credits])
VALUES ('1/10/2019 8:00:00 AM', '12/15/2019 4:30:00 PM', 11500)

INSERT [dbo].[Projects]([StartDate], [EndDate], [Credits])
VALUES ('12/1/2018 10:30:00 AM', '9/22/2019 6:00:00 PM', 15000)

INSERT [dbo].[Users]([FirstName], [LastName])
VALUES ('First Name User 1', 'Last Name User 1');

INSERT [dbo].[Users]([FirstName], [LastName])
VALUES ('First Name User 3', 'Last Name User 2');

INSERT [dbo].[Users]([FirstName], [LastName])
VALUES ('First Name User 2', 'Last Name User 3');

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (1, 1, 1, '6/15/2017 10:00:00 AM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (2, 1, 0, '7/10/2018 9:45:00 AM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (3, 1, 1, '10/1/2017 9:30:00 AM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (1, 2, 1, '5/2/2018 11:30:00 AM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (2, 3, 1, '3/21/2019 2:30:00 PM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (3, 3, 0, '1/21/2019 2:30:00 PM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (2, 4, 1, '3/21/2017 2:30:00 PM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (3, 4, 1, '3/20/2019 2:30:00 PM')

INSERT [dbo].[UserProjects]([UserId], [ProjectId], [IsActive], [AssignedDate])
VALUES (3, 5, 1, '12/20/2018 3:10:00 PM')


