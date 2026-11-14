UPDATE AspNetUserRoles
SET RoleId = '1'
WHERE UserId = (SELECT Id FROM AspNetUsers WHERE Email = 'admin@gmail.com');