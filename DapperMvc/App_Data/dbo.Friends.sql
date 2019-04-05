    USE [MBKTest]  
    GO  
    /****** Object:  Table [dbo].[tblFriends]    Script Date: 27-Jun-17,Tue 3:44:59 PM ******/  
    SET ANSI_NULLS ON  
    GO  
    SET QUOTED_IDENTIFIER ON  
    GO  
    SET ANSI_PADDING ON  
    GO  
      
    CREATE TABLE [dbo].[tblFriends](  
        [FriendID] [int] IDENTITY(1,1) NOT NULL,  
        [FriendName] [varchar](50) NULL,  
        [City] [varchar](25) NULL,  
        [PhoneNumber] [varchar](15) NULL  
    ) ON [PRIMARY]  
      
    GO  
    SET ANSI_PADDING OFF  
    GO  
