use UFdata_559_2017



exec usp_sa_getInvInfoForVouchHelp 
@cWhcode=N'',@cInvCode=N'D1004046000',@cFree1=N'',@cFree2=N'',@cFree3=N'',@cFree4=N'',@cFree5=N'',@cFree6=N'',
@cFree7=N'',@cFree8=N'',@cFree9=N'',@cFree10=N'',@cBatch=N'',@iSoType=N'1',@cSoDID=N'189575',@csocode=N'H201706035718',
@cdemandcode=N'Systemdefault',@cVmiVenCode=N'',@cHCusCode=N'5301C005'

exec usp_sa_getInvInfoForVouchHelp 
@cWhcode=N'',@cInvCode=N'D1008049000',@cFree1=N'',@cFree2=N'',@cFree3=N'',@cFree4=N'',@cFree5=N'',@cFree6=N'',
@cFree7=N'',@cFree8=N'',@cFree9=N'',@cFree10=N'',@cBatch=N'',@iSoType=N'1',@cSoDID=N'189576',@csocode=N'H201706035718',
@cdemandcode=N'Systemdefault',@cVmiVenCode=N'',@cHCusCode=N'5301C005'

exec usp_sa_getInvInfoForVouchHelp 
@cWhcode=N'',@cInvCode=N'D1008049000',@cFree1=N'',@cFree2=N'',@cFree3=N'',@cFree4=N'',@cFree5=N'',@cFree6=N'',
@cFree7=N'',@cFree8=N'',@cFree9=N'',@cFree10=N'',@cBatch=N'',@iSoType=N'1',@cSoDID=N'189576',@csocode=N'H201706035718',
@cdemandcode=N'Systemdefault',@cVmiVenCode=N'',@cHCusCode=N'5301C005'




Select bInvType,bService,cInvCode,iGroupType,cGroupCode,isnull(iinvlscost,'') as iinvlscost 
,bfree1,bconfigfree1,bfree2,bconfigfree2,bfree3,bconfigfree3,bfree4,bconfigfree4,bfree5,bconfigfree5,bfree6,bconfigfree6,bfree7,bconfigfree7,bfree8,bconfigfree8,bfree9,bconfigfree9,bfree10,bconfigfree10 from Inventory with (nolock) where cInvCode=N'16200365' and 
bSale<>0 and isnull(dEDate,'9999-12-31')>'2017-06-09'

 select IsNULL(Max(iPeriod),0) +1 As iMonth From GL_Mend where bFlag_SA=1



exec sp_executesql N'select bas_part.PartId From bas_part, Inventory where bas_part.InvCode = Inventory.cInvCode and bas_part.InvCode = @P1 and (Inventory.bConfigFree1 = 1 and bas_part.Free1 = @P2 or Inventory.bConfigFree1 = 0 and bas_part.Free1 = '''') and 
(Inventory.bConfigFree2 = 1 and bas_part.Free2 = @P3 or Inventory.bConfigFree2 = 0 and bas_part.Free2 = '''') and (Inventory.bConfigFree3 = 1 and bas_part.Free3 = @P4 or Inventory.bConfigFree3 = 0 and bas_part.Free3 = '''') and (Inventory.bConfigFree4 = 1 and 
bas_part.Free4 = @P5 or Inventory.bConfigFree4 = 0 and bas_part.Free4 = '''') and (Inventory.bConfigFree5 = 1 and bas_part.Free5 = @P6 or Inventory.bConfigFree5 = 0 and bas_part.Free5 = '''') and (Inventory.bConfigFree6 = 1 and bas_part.Free6 = @P7 or 
Inventory.bConfigFree6 = 0 and bas_part.Free6 = '''') and (Inventory.bConfigFree7 = 1 and bas_part.Free7 = @P8 or Inventory.bConfigFree7 = 0 and bas_part.Free7 = '''') and (Inventory.bConfigFree8 = 1 and bas_part.Free8 = @P9 or Inventory.bConfigFree8 = 0 and 
bas_part.Free8 = '''') and (Inventory.bConfigFree9 = 1 and bas_part.Free9 = @P10 or Inventory.bConfigFree9 = 0 and bas_part.Free9 = '''') and (Inventory.bConfigFree10 = 1 and bas_part.Free10 = @P11 or Inventory.bConfigFree10 = 0 and bas_part.Free10 = 
'''')',N'@P1 nvarchar(200),@P2 nvarchar(200),@P3 nvarchar(200),@P4 nvarchar(200),@P5 nvarchar(200),@P6 nvarchar(200),@P7 nvarchar(200),@P8 nvarchar(200),@P9 nvarchar(200),@P10 nvarchar(200),@P11 
nvarchar(200)',N'D2104013000',N'',N'',N'',N'',N'',N'',N'',N'',N'',N''

exec Usp_BO_CopyOrdBomFromCbom N'5301C005',82382,189578,N'H201706035718',4,'2017-07-10 00:00:00:000',N'559',N'17057777','2017-06-15 00:00:00:000'


select i.bPTOModel,  i.iInvAdvance from inventory i,bas_part a where a.PartId =82382  and i.cinvcode = a.invcode








 Update SO_SODetails SET 
cinvcode=N'D1004046000',dpredate='2017-07-10',iquantity=420,iquotedprice=0,iunitprice=26,itaxunitprice=26,imoney=10920,itax=0,isum=10920,idiscount=0,inatunitprice=177.034,inatmoney=74354.28,inattax=0,inatsum=74354.28,inatdiscount=0,ifhnum=0,ifhquantity=0,ifhmoney=0,ikpquantity=0,ikpnum=0,ikpmoney=0,cmemo=N'NHDR-3204AHD',cfree1=Null,cfree2=Null,isosid=189575,kl=100,kl2=100,cinvname=N'DVR',itaxrate=0,cdefine22=N'P制带客户LOGO',cdefine23=N'英文',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,id=1829209,cdefine31=N'NOVUS',cdefine33=N'NOVUS 
专用程序，出货版本请先与业务、产品管理部确认',fpurquan=0,fsalecost=0,fsaleprice=0,iquoid=0,cscloser=Null,dpremodate='2017-06-09',irowno=1,imoquantity=0,iprekeepquantity=0,iprekeeptotquantity=0,iprekeeptotnum=0,dreleasedate='2017-07-10',fcusminprice=0,fimquantity=0,fomquantity=0,ballpurchase=0,finquantity=0,foutquantity=0,iexchsum=0,fretquantity=0,fretnum=0,borderbom=0,borderbomover=0,idemandtype=1,cdemandcode=N'Systemdefault',cdemandmemo=N'系统默认分类',busecusbom=0,cSOCode=N'H201706035718' 
Where  iSOsID= 189575

 Update SO_SODetails SET 
cinvcode=N'D1008049000',dpredate='2017-07-10',iquantity=210,iquotedprice=0,iunitprice=35,itaxunitprice=35,imoney=7350,itax=0,isum=7350,idiscount=0,inatunitprice=238.315,inatmoney=50046.15,inattax=0,inatsum=50046.15,inatdiscount=0,ifhnum=0,ifhquantity=0,ifhmoney=0,ikpquantity=0,ikpnum=0,ikpmoney=0,cmemo=N'NHDR-3208AHD',cfree1=Null,cfree2=Null,isosid=189576,kl=100,kl2=100,cinvname=N'DVR',itaxrate=0,cdefine22=N'P制带客户LOGO',cdefine23=N'英文',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,id=1829209,cdefine31=N'NOVUS',cdefine33=N'NOVUS 
专用程序，出货版本请先与业务、产品管理部确认',fpurquan=0,fsalecost=0,fsaleprice=0,iquoid=0,cscloser=Null,dpremodate='2017-06-09',irowno=3,imoquantity=0,iprekeepquantity=0,iprekeeptotquantity=0,iprekeeptotnum=0,dreleasedate='2017-07-10',fcusminprice=0,fimquantity=0,fomquantity=0,ballpurchase=0,finquantity=0,foutquantity=0,iexchsum=0,fretquantity=0,fretnum=0,borderbom=0,borderbomover=0,idemandtype=1,cdemandcode=N'Systemdefault',cdemandmemo=N'系统默认分类',busecusbom=0,cSOCode=N'H201706035718' 
Where  iSOsID= 189576

 Update SO_SODetails SET 
cinvcode=N'D1016042000',dpredate='2017-07-10',iquantity=120,iquotedprice=0,iunitprice=78,itaxunitprice=78,imoney=9360,itax=0,isum=9360,idiscount=0,inatunitprice=531.102,inatmoney=63732.24,inattax=0,inatsum=63732.24,inatdiscount=0,ifhnum=0,ifhquantity=0,ifhmoney=0,ikpquantity=0,ikpnum=0,ikpmoney=0,cmemo=N'NHDR-3216AHD',cfree1=Null,cfree2=Null,isosid=189577,kl=100,kl2=100,cinvname=N'DVR',itaxrate=0,cdefine22=N'P制带客户LOGO',cdefine23=N'英文',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,id=1829209,cdefine31=N'NOVUS',cdefine33=N'NOVUS 
专用程序，出货版本请先与业务、产品管理部确认',fpurquan=0,fsalecost=0,fsaleprice=0,iquoid=0,cscloser=Null,dpremodate='2017-06-09',irowno=3,imoquantity=0,iprekeepquantity=0,iprekeeptotquantity=0,iprekeeptotnum=0,dreleasedate='2017-07-10',fcusminprice=0,fimquantity=0,fomquantity=0,ballpurchase=0,finquantity=0,foutquantity=0,iexchsum=0,fretquantity=0,fretnum=0,borderbom=0,borderbomover=0,idemandtype=1,cdemandcode=N'Systemdefault',cdemandmemo=N'系统默认分类',busecusbom=0,cSOCode=N'H201706035718' 
Where  iSOsID= 189577

 Update SO_SODetails SET 
cinvcode=N'D2104013000',dpredate='2017-07-10',iquantity=100,iquotedprice=0,iunitprice=48,itaxunitprice=48,imoney=4800,itax=0,isum=4800,idiscount=0,inatunitprice=326.832,inatmoney=32683.2,inattax=0,inatsum=32683.2,inatdiscount=0,cmemo=N'NHDR-4M5304AHD',cfree1=Null,cfree2=Null,isosid=189578,kl=100,kl2=100,cinvname=N'DVR',itaxrate=0,cdefine22=N'P制带客户LOGO',cdefine23=N'英文',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,id=1829209,cdefine31=N'NOVUS',cdefine33=N'NOVUS 
专用程序，出货版本请先与业务、产品管理部确认',fsalecost=0,fsaleprice=0,cscloser=Null,dpremodate='2017-06-09',irowno=4,dreleasedate='2017-07-10',fcusminprice=0,ballpurchase=0,finquantity=0,foutquantity=0,fretquantity=0,fretnum=0,borderbom=1,borderbomover=0,idemandtype=1,cdemandcode=N'Systemdefault',cdemandmemo=N'系统默认分类',busecusbom=1,cSOCode=N'H201706035718' 
Where  iSOsID= 189578


