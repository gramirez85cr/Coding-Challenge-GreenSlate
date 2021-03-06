CREATE DATABASE [CodingChallengeGRS]
GO

USE [CodingChallengeGRS]

CREATE TABLE [dbo].[Projects] (
    [Id] [int] NOT NULL IDENTITY,
    [StartDate] [datetime] NOT NULL,
    [EndDate] [datetime] NOT NULL,
    [Credits] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Projects] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[UserProjects] (
    [UserId] [int] NOT NULL,
    [ProjectId] [int] NOT NULL,
    [IsActive] [bit] NOT NULL,
    [AssignedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.UserProjects] PRIMARY KEY ([UserId], [ProjectId])
)
CREATE INDEX [IX_UserId] ON [dbo].[UserProjects]([UserId])
CREATE INDEX [IX_ProjectId] ON [dbo].[UserProjects]([ProjectId])
CREATE TABLE [dbo].[Users] (
    [Id] [int] NOT NULL IDENTITY,
    [FirstName] [nvarchar](50) NOT NULL,
    [LastName] [nvarchar](50) NOT NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([Id])
)
ALTER TABLE [dbo].[UserProjects] ADD CONSTRAINT [FK_dbo.UserProjects_dbo.Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Projects] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[UserProjects] ADD CONSTRAINT [FK_dbo.UserProjects_dbo.Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201905090704478_Initial', N'CodingChallenge.DataModel.Migrations.Configuration',  0x1F8B0800000000000400DD5ADB6EE336107D2FD07F10F45864AD248B026D60EF22EB6C0AA39B0BA2ECA26F0B5A1A3B6C294AA5A8C046D12FEB433FA9BFD0A16EA628C9A61DAFEB2EFC6253E499E1F070383AF43F7FFD3D7CBB8898F30C22A5311FB9678353D7011EC421E5F3919BC9D9AB1FDCB76FBEFD66F83E8C16CEA7AADF6BD50F47F274E43E49995C785E1A3C4144D241440311A7F14C0E8238F248187BE7A7A73F7A67671E20848B588E337CC8B8A411E43FF0E738E601243223EC260E81A5653B3EF17354E7964490262480913BCE7D1B3F11C680CF61704524C947B9CE25A3041DF281CD5C87701E4B22D1DD8B8F29F852C47CEE27D840D8E33201EC37232C85721A17ABEEB6333A3D5733F256032BA8204B651C6D0978F6BA0C91670EDF29D06E1D420CE27B0CB65CAA59E7811CB9F722FE1502E93AA6AD8B3113AA5F3BCCC5C20CCA91274EF1DCA93B38AF9CA2CB49CD122493FA60DF8CC94CC0884326056127CE7D366534F819968FF16FC0473C634C77185DC6678D066C42D30908B97C8059398D49E83A5E739C670EAC8769638A194EB87C7DEE3AB7689C4C19D47CD0A2E1CB58C04FC0411009E13D91120457189047B465DDB0E54B2224F2132A93EAFB23F2BEC3EA7AA4F73CDC0BCE58404865BA29043AC8D05BD1672DA9709789DD89A58D3E0E722987DA04EBEC5AFABD0B1D2B2BF6EBD1C6D0CCBF0466925E06923ED7247B17C70C08DF1AE7324DE99CC38E84BD25CF749E53A67B96AEF3002C7F9E3ED1A448F63A793ED7FDAE451C3DC4ACC9CCEAF1673FCE44A0FC8BFBFB3C12310769EFA2C2D8E85FD1A9DB39F57DAD6779872EB7B6DAA53B6ECFE3D897C79EF4AFA948A5FA5A99C4D20383E63A3764F10183269F46EEF7583D5DD305845543E9C5474EB1F4C2315264DB27F70FE42086FBA886FB3E0E681EC3F689506FCBE60CF05C732CF668311D6327E1C49062344152A13723F7BB567CD6A357DB4843EF413E734D5ADEF12B6020C15129535578639206246C2F11C62A6CB6209341282A1186656F8A7B8372D9A63DE5014D08DBECBF31D472CF28D76A23E6932B48802BBA6F5E1B1BEBBDC7A372A2B665C46D5398869EC6377B1AE6E9CF8625CD54BC57023692B8017DDCD4D33D3F30EFF4F5B031DD5BBEED9F71453AC431124780A84A6DFC0D8BAE52185D2B8FDBB44CB8266B149E0FB2B97FB06A5F255E3361B588D78468B0B685D2786A81D4E549415E63B016B04E5F56C59AD6734D4D67AEA5DDF1514FC188438B1A76E78506B75A1973EF3567BE65548A58AE0F493B91D9A5B21706A391BB0CAC6DC2501511F5AE59493E5EA1F954DA90D7230E0D6F4892607DA38945658BE3974AD12B7F7BED242A30BC20ED90506A6F6B4B582B9239184FF32A1AF24250A95353A24AA8711875742B7244CF96ABAC1869A0BD52D55EAC06A8EF5516EA51CB063D7B6A15C66B9C59A492715E10B759DF1E99EB758411D1517E8F639645BCFF58E81FADA9283A88D66C8F55EB283A52DD688F53EB283A4EDDD8C6197A46505BA7526B115B877993145694D177F87E58B306D182396B47F7C5BA3AC9F550F79DEEFD285A11AA03ADA94DFBB1564A4983D575AB3D52532BD1D19A4F8E8A51FBCA405D479825890E957BB497791D446BB6C75ABD9EEB50ABD603AF71EB0436BBD4D6EB93D8387187E5E9677567D33C0E8B2EAE83217AA6A13A0AFD652A21CAD931F07F67634671BEAB0E3784D319A4B2D08EDCF3D3B373E3BEE778EE5EBC340D99DD05CCC1F52FAA82BA51E1DA52786ADD7384F85DEEE19E63671CE39E239FF5FE6F39FE27B70AF9EC5B6FA1137C075E8CDC3FF22117CEE497CFC5A813E74EE086BB704E9D3F5F7E15616BBB1EF822F3E615C6946E5A77BBEB0B4B1E6E27C27F1D7BBF2577F367228227225ABAF30BD5ECDD70BF8C585DBF351F583BEE7C27DF5D9EDC490FECAFFEBFA4FEF7F509CD87957E8F81393DF5FE7F4E9B23908A4DB5C84A105EA7071705369E5CD31857B9488FBD6AE50BD4E22E3B5A073B5BBD72721F7A1BF6704AB31198862266A9A2DAAAB0C72123B7BC3DE034B79089DB2FA3B84FB5BF19629AC80BBB0A42FDE99043D0D8A1759F099FC555A2303CAABA18E5CA0D48826522B91492CE4820F17100584AAA0BF84F8465EAE5269A4238E177994C3289538668CA1A7F275009679DFD5C0B6FFA3CBC4BF2FF9AEC630AE8265595EE1D7F975116D67E5F7794553D102A9395C5A55A4BA98ACCF9B246BA8DB9255019BE3A013F429430044BEFB84F5481BFBD6FC8C00F3027C1B2D214FA41362F4433ECC32B4AE682446989B11A8F3F91C361B478F32FB26AD3526D2B0000 , N'6.2.0-61023')