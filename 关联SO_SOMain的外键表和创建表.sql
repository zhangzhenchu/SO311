USE [UFDATA_559_2017]
GO
/****** 对象:  Table [dbo].[SO_SOMain]    脚本日期: 06/02/2017 17:30:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SO_SOMain](
	[cSTCode] [nvarchar](2) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[dDate] [datetime] NOT NULL,
	[cSOCode] [nvarchar](30) COLLATE Chinese_PRC_CI_AS NULL,
	[cCusCode] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cDepCode] [nvarchar](12) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[cPersonCode] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cSCCode] [nvarchar](2) COLLATE Chinese_PRC_CI_AS NULL,
	[cCusOAddress] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[cPayCode] [nvarchar](3) COLLATE Chinese_PRC_CI_AS NULL,
	[cexch_name] [nvarchar](8) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[iExchRate] [float] NULL,
	[iTaxRate] [float] NULL,
	[iMoney] [money] NULL,
	[cMemo] [nvarchar](60) COLLATE Chinese_PRC_CI_AS NULL,
	[iStatus] [tinyint] NULL,
	[cMaker] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cVerifier] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cCloser] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[bDisFlag] [bit] NULL,
	[cDefine1] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine2] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine3] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine4] [datetime] NULL,
	[cDefine5] [int] NULL,
	[cDefine6] [datetime] NULL,
	[cDefine7] [float] NULL,
	[cDefine8] [nvarchar](4) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine9] [nvarchar](8) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine10] [nvarchar](60) COLLATE Chinese_PRC_CI_AS NULL,
	[bReturnFlag] [bit] NOT NULL CONSTRAINT [DF__SO_SOMain__bRetu__2AA11C70]  DEFAULT (0),
	[cCusName] [nvarchar](120) COLLATE Chinese_PRC_CI_AS NULL,
	[bOrder] [bit] NULL CONSTRAINT [DF__SO_SOMain__bOrde__0505836D]  DEFAULT (0),
	[ID] [int] NOT NULL CONSTRAINT [DF__SO_SOMain__ID__6DC2F6B9]  DEFAULT (0),
	[iVTid] [int] NOT NULL CONSTRAINT [DF__SO_SOMain__iVTid__1C7DE5A2]  DEFAULT (0),
	[ufts] [timestamp] NULL,
	[cChanger] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cBusType] [nvarchar](8) COLLATE Chinese_PRC_CI_AS NOT NULL CONSTRAINT [DF__SO_SOMain__cBusT__1D7209DB]  DEFAULT ('普通销售'),
	[cCreChpName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine11] [nvarchar](120) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine12] [nvarchar](120) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine13] [nvarchar](120) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine14] [nvarchar](120) COLLATE Chinese_PRC_CI_AS NULL,
	[cDefine15] [int] NULL,
	[cDefine16] [float] NULL,
	[coppcode] [nvarchar](30) COLLATE Chinese_PRC_CI_AS NULL,
	[cLocker] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[dPreMoDateBT] [datetime] NULL,
	[dPreDateBT] [datetime] NULL,
	[cgatheringplan] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[caddcode] [nvarchar](30) COLLATE Chinese_PRC_CI_AS NULL,
	[iverifystate] [int] NULL DEFAULT (0),
	[ireturncount] [tinyint] NULL DEFAULT (0),
	[iswfcontrolled] [tinyint] NULL DEFAULT (0),
	[icreditstate] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[cmodifier] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[dmoddate] [datetime] NULL,
	[dverifydate] [datetime] NULL,
	[ccusperson] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[dcreatesystime] [datetime] NULL DEFAULT (getdate()),
	[dverifysystime] [datetime] NULL,
	[dmodifysystime] [datetime] NULL,
	[iflowid] [int] NULL,
	[bcashsale] [bit] NULL,
	[cgathingcode] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[cChangeVerifier] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[dChangeVerifyDate] [datetime] NULL,
	[dChangeVerifyTime] [datetime] NULL,
	[outid] [uniqueidentifier] NULL,
 CONSTRAINT [PK_SO_SOMain] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_bindefault @defname=N'[dbo].[SO_SOMain_cexch_name_D]', @objname=N'[dbo].[SO_SOMain].[cexch_name]' , @futureonly='futureonly'
GO
EXEC sys.sp_bindefault @defname=N'[dbo].[SO_SOMain_iExchRate_D]', @objname=N'[dbo].[SO_SOMain].[iExchRate]' , @futureonly='futureonly'
GO
EXEC sys.sp_bindefault @defname=N'[dbo].[SO_SOMain_iTaxRate_D]', @objname=N'[dbo].[SO_SOMain].[iTaxRate]' , @futureonly='futureonly'
GO
EXEC sys.sp_bindefault @defname=N'[dbo].[SO_SOMain_iMoney_D]', @objname=N'[dbo].[SO_SOMain].[iMoney]' , @futureonly='futureonly'
GO
EXEC sys.sp_bindefault @defname=N'[dbo].[SO_SOMain_iStatus_D]', @objname=N'[dbo].[SO_SOMain].[iStatus]' , @futureonly='futureonly'
GO
EXEC sys.sp_bindefault @defname=N'[dbo].[SO_SOMain_bDisFlag_D]', @objname=N'[dbo].[SO_SOMain].[bDisFlag]' , @futureonly='futureonly'
GO
EXEC sys.sp_bindefault @defname=N'[dbo].[SO_SOMain_cDefine7_D]', @objname=N'[dbo].[SO_SOMain].[cDefine7]' , @futureonly='futureonly'
GO
ALTER TABLE [dbo].[SO_SOMain]  WITH CHECK ADD  CONSTRAINT [FK__SO_SOMain__cCusC__2B554987] FOREIGN KEY([cCusCode])
REFERENCES [dbo].[Customer] ([cCusCode])
GO
ALTER TABLE [dbo].[SO_SOMain] CHECK CONSTRAINT [FK__SO_SOMain__cCusC__2B554987]
GO
ALTER TABLE [dbo].[SO_SOMain]  WITH CHECK ADD  CONSTRAINT [FK__SO_SOMain__cDepC__3B8BB150] FOREIGN KEY([cDepCode])
REFERENCES [dbo].[Department] ([cDepCode])
GO
ALTER TABLE [dbo].[SO_SOMain] CHECK CONSTRAINT [FK__SO_SOMain__cDepC__3B8BB150]
GO
ALTER TABLE [dbo].[SO_SOMain]  WITH CHECK ADD  CONSTRAINT [FK__SO_SOMain__cexch__5733CBC5] FOREIGN KEY([cexch_name])
REFERENCES [dbo].[foreigncurrency] ([cexch_name])
GO
ALTER TABLE [dbo].[SO_SOMain] CHECK CONSTRAINT [FK__SO_SOMain__cexch__5733CBC5]
GO
ALTER TABLE [dbo].[SO_SOMain]  WITH CHECK ADD  CONSTRAINT [FK__SO_SOMain__cPayC__08CB2759] FOREIGN KEY([cPayCode])
REFERENCES [dbo].[PayCondition] ([cPayCode])
GO
ALTER TABLE [dbo].[SO_SOMain] CHECK CONSTRAINT [FK__SO_SOMain__cPayC__08CB2759]
GO
ALTER TABLE [dbo].[SO_SOMain]  WITH CHECK ADD  CONSTRAINT [FK__SO_SOMain__cPers__19018F22] FOREIGN KEY([cPersonCode])
REFERENCES [dbo].[Person] ([cPersonCode])

select* from [dbo].[SaleType] 
GO
ALTER TABLE [dbo].[SO_SOMain] CHECK CONSTRAINT [FK__SO_SOMain__cPers__19018F22]
GO
ALTER TABLE [dbo].[SO_SOMain]  WITH CHECK ADD  CONSTRAINT [FK__SO_SOMain__cSCCo__56FEC19B] FOREIGN KEY([cSCCode])
REFERENCES [dbo].[ShippingChoice] ([cSCCode])
GO
ALTER TABLE [dbo].[SO_SOMain] CHECK CONSTRAINT [FK__SO_SOMain__cSCCo__56FEC19B]
GO
ALTER TABLE [dbo].[SO_SOMain]  WITH CHECK ADD  CONSTRAINT [FK__SO_SOMain__cSTCo__5051C40C] FOREIGN KEY([cSTCode])
REFERENCES [dbo].[SaleType] ([cSTCode])
GO
ALTER TABLE [dbo].[SO_SOMain] CHECK CONSTRAINT [FK__SO_SOMain__cSTCo__5051C40C]