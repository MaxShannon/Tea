INSERT INTO dbo.UserPrivilegesSet
        ( PrivilegeName )
VALUES  ( N'����Ա'  -- PrivilegeName - nvarchar(max)
          )

INSERT INTO	dbo.UserInfo
        ( UserName ,
          Password ,
          DelFlag ,
          UserPrivilegesId ,
          RealName
        )
VALUES  ( N'max' , -- UserName - nvarchar(max)
          N'123' , -- Password - nvarchar(max)
          0 , -- DelFlag - bit
          1 , -- PowerInfoId - int
          N'������'  -- RealName - nvarchar(max)
        )