alter table UserRoleMaps Add foreign key(UserId)  
references Users(Id)  
  
alter table UserRoleMaps Add foreign key(RoleId)  
references Roles(id)


