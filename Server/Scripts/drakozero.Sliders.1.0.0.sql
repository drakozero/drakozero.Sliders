/*  
Create drakozeroSlider table
*/

CREATE TABLE [dbo].[drakozeroSlider](
	[SliderId] [int] IDENTITY(1,1) NOT NULL,
	[ModuleId] [int] NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Source] [int] NOT NULL,
	[Alt] [nvarchar](256) NULL,
	[Caption] [nvarchar](256) NULL,
	[Header] [nvarchar](256) NULL,
	[ActionLink] [nvarchar](256) NULL,
	[ActionLinkTarget] [nvarchar](256) NULL,
	[Enabled] [bit] NOT NULL,
	[Time] [int] NULL,
	[Order] [int] NULL,
	[CreatedBy] [nvarchar](256) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](256) NOT NULL,
	[ModifiedOn] [datetime] NOT NULL,
  CONSTRAINT [PK_drakozeroSlider] PRIMARY KEY CLUSTERED 
  (
	[SliderId] ASC
  )
)
GO

/*  
Create foreign key relationships
*/
ALTER TABLE [dbo].[drakozeroSlider]  WITH CHECK ADD  CONSTRAINT [FK_drakozeroSlider_Module] FOREIGN KEY([ModuleId])
REFERENCES [dbo].Module ([ModuleId])
ON DELETE CASCADE
GO