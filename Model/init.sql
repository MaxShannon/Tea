INSERT INTO dbo.UserPrivilegesSet
        ( PrivilegeName )
VALUES  ( N'管理员'  -- PrivilegeName - nvarchar(max)
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
          N'刘向荣'  -- RealName - nvarchar(max)
        )