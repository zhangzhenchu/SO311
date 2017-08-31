 select IsNULL(Max(iPeriod),0) +1 As iMonth From GL_Mend where bFlag_SA=1
use UFDATA_559_2017
declare @p13 int
set @p13=0
exec SA_CheckValid N'so',0,N'00000004',N'050201',N'07090070',N'人民币',N'H',N'002',N'',NULL,0,N'2017-06-06',@p13 output
select @p13


Select bInvType,bService,cInvCode,iGroupType,cGroupCode,isnull(iinvlscost,'') as iinvlscost 
,bfree1,bconfigfree1,bfree2,bconfigfree2,bfree3,bconfigfree3,bfree4,bconfigfree4,bfree5,bconfigfree5,bfree6,bconfigfree6,bfree7,bconfigfree7,bfree8,bconfigfree8,bfree9,bconfigfree9,bfree10,bconfigfree10 from Inventory with (nolock) where cInvCode=N'10000104' 
and bSale<>0 and isnull(dEDate,'9999-12-31')>'2017-06-06'

declare @p1 int
set @p1=4
declare @p7 bit
set @p7=0
exec sp_prepexecrpc @p1 output,N'usp_WF_IsFlowControlled',N'17',N'17.Submit',2017,N'559',@p7 output
select @p1, @p7

 Select cValue From AccInformation where cSysID=N'AA' and cName=N'SAPluginEnabled' 

SELECT csocode FROM SO_SOMain WHERE csocode=N'H201706035671' and id<>0

declare @p5 int
set @p5=1829117
declare @p6 int
set @p6=189208
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6

SELECT * FROM SO_SOMain with (nolock) WHERE 1=0


 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829117,95,Null,N'普通销售',Null,N'H',Null,'2017-06-06',N'H201706035671',N'00000004',N'050201',N'07090070',Null,Null,N'002',N'人民币',1,0,Null,N'调整开票误差',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-06','2017-06-06',0,Null,N'珠海市香洲信达智能电子产品商行',0,N'陈旭文',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


IF @@TRANCOUNT > 0 ROLLBACK TRAN


 Select cValue From AccInformation where cSysID=N'AA' and cName=N'SAPluginEnabled' 

SELECT csocode FROM SO_SOMain WHERE csocode=N'H201706035671' and id<>1829117

declare @p5 int
set @p5=1829118
declare @p6 int
set @p6=189209
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6

SELECT * FROM SO_SOMain with (nolock) WHERE 1=0


 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829118,95,Null,N'普通销售',Null,N'H',Null,'2017-06-06',N'H201706035671',N'00000004',N'050201',N'07090070',Null,Null,N'002',N'人民币',1,0,Null,N'调整开票误差',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-06','2017-06-06',0,Null,N'珠海市香洲信达智能电子产品商行',0,N'陈旭文',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)
1829118
SELECT * FROM SO_SODetails with (nolock) WHERE 1=0

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'H201706035671',N'10000104','2017-06-06',1,Null,0,2.94,3,2.94,.06,3,0,2.94,2.94,.06,3,0,Null,Null,Null,Null,Null,Null,N'备用金',Null,Null,189209,100,100,N'贴片电容',2,N'N制中性',N'俄文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829118,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-06',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035674',N'10000114','2017-06-06',3,Null,0,3.92,4,11.76,.24,12,0,3.92,11.76,.24,12,0,Null,Null,Null,Null,Null,Null,N'调整开票误差',Null,Null,189267,100,100,N'贴片陶瓷电容',2,N'N制带公司LOGO',N'英文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829176,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-06',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)
insert into SO_SODetails(
csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,
inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,
cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,
cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,
fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,
ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,
iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
('{0}','{1}',getdate(),'{2}',Null,0,2.94,'{3}',2.94,'{4}','{5}',0,2.94,2.94,'{6}','{7}',0,Null,Null,Null,Null,Null,Null,
'{8}',Null,Null,'{9}',100,100,'{10}',2,'{11}','{12}',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,
Null,Null,Null,Null,Null,Null,Null,Null,'{13}',Null,Null,Null,'{14}',Null,Null,Null,0,0,Null,Null,Null,getdate(),1,
Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,
Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)



SELECT cid, ctext, ccode FROM GL_bdigest


Update customer set bCusState =1 where ccuscode=N'00000004' AND ISNULL(bCusState,0)=0


Select * From VoucherNumber Where CardNumber='17'

Select * from VoucherPrefabricateview Where CardNumber='17'

Select cCode from Vouchercontrapose Where cContent='SaleType' and cSeed='H'

select cNumber as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL

Select cCode from Vouchercontrapose Where cContent='SaleType' and cSeed='H'

select cNumber as Maxnumber From VoucherHistory  with (ROWLOCK)  Where  CardNumber='17' and cContent is NULL

update VoucherHistory set cNumber='35671' Where  CardNumber='17' and cContent is NULL

update so_sodetails set csocode='H201706035671' where id=1829118

Select * from SaleOrderQ where id=1829118
Select * ,N'' as editprop From SaleOrderSQ where id = 1829118 order by irowno

declare @p1 int
set @p1=180150017
declare @p3 int
set @p3=8
declare @p4 int
set @p4=1
declare @p5 int
set @p5=1
exec sp_cursoropen @p1 output,N'select convert(money,pubufts) as pubufts  from vouchertemplates_base where vt_cardnumber=''17'' and vt_id=''95''',@p3 output,@p4 output,@p5 output
select @p1, @p3, @p4, @p5

select cFieldAuthID from Vouchers where cardnumber='17'



use UFDATA_559_2017

select * from SO_SOMain where csocode='Y201706035672'

select * from SO_SOMain where id='1829156'

select * from SO_SODetails where isosid='189421'

delete from SO_SOMain where id='1829155'
select id from SO_SOMain where id='1829156'

select isosid from SO_SODetails order by isosid

select * from SO_SODetails where isosid='189421'

select * from  SO_SOMain where  csocode='G201706035685'

select * from SO_SOMain where csocode='H201706035692'

select * from  SO_SODetails where csocode='H201706035675'

select cNumber as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL

select * from VoucherHistory where CNumber=' '
declare @p5 int
set @p5=1829118
declare @p6 int
set @p6=189209
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6

 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(@p5,95,Null,N'普通销售',Null,N'H',Null,'2017-06-07',N'H201706035674',N'00000001',N'050202',N'07090070',Null,Null,N'004',N'人民币',1,0,Null,N'原始发票号码：',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-07','2017-06-07',0,Null,N'广州永创电子科技有限公司',0,N'吕中南',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,
cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'H201706035674',N'10000104','2017-06-07',4,Null,0,4.95,5,19.8,.2,20,0,4.95,19.8,.2,20,0,Null,Null,Null,Null,Null,Null,N'采购入库',Null,Null,@p6,100,100,N'贴片电容',1,N'N制带客户LOGO',N'日文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,@p5,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-07',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

select isnull(cNumber,0) as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL
select cNumber as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL
update VoucherHistory set cNumber='35674' Where  CardNumber='17' and cContent is NULL




declare @p5 int
set @p5=1829118
declare @p6 int
set @p6=189209
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6


 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829159,95,Null,N'普通销售',Null,N'G',Null,'2017-06-07',N'G201706035677',N'00000006',N'050201',N'07090070',Null,Null,N'004',N'人民币',1,0,Null,N'采购入库',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-07','2017-06-07',0,Null,N'南宁柏沃电子科技有限公司',0,N'赖柏春',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035677',N'10000105','2017-06-07',2,Null,0,3.885,4,7.77,.23,8,0,3.885,7.77,.23,8,0,Null,Null,Null,Null,Null,Null,N'国内销售收入',Null,Null,189424,100,100,N'贴片电容',3,N'P制带客户LOGO',N'俄文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829159,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-07',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)
 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035677',N'10000104','2017-06-07',3,Null,0,5.8833,6,17.65,.35,18,0,5.8833,17.65,.35,18,0,Null,Null,Null,Null,Null,Null,N'调整开票误差',Null,Null,189425,100,100,N'贴片电容',2,N'N制带公司LOGO',N'英文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829159,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-07',2,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)


Update customer set bCusState =1 where ccuscode=N'00000006' AND ISNULL(bCusState,0)=0

update VoucherHistory set cNumber='35677' Where  CardNumber='17' and cContent is NULL

update so_sodetails set csocode='G201706035677' where id=1829159



select isosid ,id from SO_SODetails where  id='1829161'


declare @p13 int
set @p13=0
exec SA_CheckValid N'so',0,N'00000004',N'050201',N'07090070',N'人民币',N'G',N'003',N'',NULL,0,N'2017-06-07',@p13 output
select @p13

declare @p1 int
set @p1=4
declare @p7 bit
set @p7=0
exec sp_prepexecrpc @p1 output,N'usp_WF_IsFlowControlled',N'17',N'17.Submit',2017,N'559',@p7 output
select @p1, @p7

declare @p5 int
set @p5=0
declare @p6 int
set @p6=0
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6

189434    
189437   1829165
189438   1829166
189440   1829167
189443   1829168

 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829161,95,Null,N'普通销售',Null,N'G',Null,'2017-06-07',N'G201706035678',N'00000004',N'050201',N'07090070',Null,Null,N'003',N'人民币',1,0,Null,N'收发票',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-07','2017-06-07',0,Null,N'珠海市香洲信达智能电子产品商行',0,N'陈旭文',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035678',N'10000118','2017-06-07',2,Null,0,2.97,3,5.94,.06,6,0,2.97,5.94,.06,6,0,Null,Null,Null,Null,Null,Null,N'计提本月工资',Null,Null,189427,100,100,N'片状电容器(Z#6)',1,N'N制带客户LOGO',N'中文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829161,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-07',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035678',N'10000106','2017-06-07',3,Null,0,3.92,4,11.76,.24,12,0,3.92,11.76,.24,12,0,Null,Null,Null,Null,Null,Null,N'采购入库',Null,Null,189428,100,100,N'▼贴片电容',2,N'N制带客户LOGO',N'俄文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829161,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-07',2,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035678',N'10000116','2017-06-07',4,Null,0,4.855,5,19.42,.58,20,0,4.855,19.42,.58,20,0,Null,Null,Null,Null,Null,Null,N'国外销售收入',Null,Null,189429,100,100,N'贴片陶瓷电容',3,N'P制中性',N'英文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829161,Null,Null,Null,N'带公司LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-07',3,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

Update customer set bCusState =1 where ccuscode=N'00000004' AND ISNULL(bCusState,0)=0
update VoucherHistory set cNumber='35678' Where  CardNumber='17' and cContent is NULL
update so_sodetails set csocode='G201706035678' where id=1829161


exec sp_reset_connection 

set implicit_transactions on 

set implicit_transactions off 




declare @p1 int
set @p1=180150033
declare @p3 int
set @p3=8
declare @p4 int
set @p4=1
declare @p5 int
set @p5=1
exec sp_cursoropen @p1 output,N'select convert(money,pubufts) as pubufts  from vouchertemplates_base where vt_cardnumber=''17'' and vt_id=''95''',@p3 output,@p4 output,@p5 output
select @p1, @p3, @p4, @p5


select isnull(bCreditDate,0) as bCreditDate,isnull(cCusSAProtocol,N'') as cCusSAProtocol,isnull(ccusotherprotocol,N'') as ccusotherprotocol  from customer left join aa_agreement on customer.cCusSAProtocol=aa_agreement.ccode  where ccuscode = N'00000002' and  
iLZYJ in (0,1) 
select isnull(b.cwhcode,N'') as cwhcode,isnull(b.cwhname,N'') as cwhname,isnull(bproxywh,0) as bproxywh from customer a left join warehouse b on a.cCusWhCode=b.cwhcode where a.ccuscode=N'00000002'



 SELECT isnull(Person.cPersonCode,N'') as chandler,isnull(cPersonName,N'') as cPersonName,isnull(person.cPersonCode,N'') as cpersoncode,
isnull(department.cdepcode,N'') as cdepcode,isnull(cDepName,N'') as cDepName, cusadd.cdeliveradd as cshipaddress 
,cusadd.caddcode,cusadd.cdeliverunit,crm.ccontactname ,crm.cmobilephone,crm.cofficephone, Customer.cCusCode, Customer.cCusName,
 Customer.cCusAbbName, Customer.cCCCode, Customer.cDCCode, Customer.cTrade, Customer.cCusAddress, Customer.cCusPostCode, 
Customer.cCusRegCode, Customer.cCusBank, Customer.cCusAccount, Customer.dCusDevDate, Customer.cCusLPerson,
 Customer.cCusEmail,Customer.cCusPerson, Customer.cCusPhone, Customer.cCusFax,Customer.cCusBP, Customer.cCusHand, Customer.cCusPPerson, 
Customer.iCusDisRate, Customer.cCusCreGrade, Customer.iCusCreLine,Customer.iCusCreDate, Customer.cCusPayCond,
Customer.cCusOAddress, Customer.cCusOType,Customer.cCusHeadCode, Customer.cCusWhCode,Customer.cCusDepart, Customer.iARMoney, 
Customer.dLastDate,Customer.iLastMoney, Customer.dLRDate, Customer.iLRMoney,Customer.dEndDate, Customer.iFrequency,
 Customer.cCusDefine1,Customer.cCusDefine2, Customer.cCusDefine3, Customer.iCostGrade,Customer.cCreatePerson, 
Customer.cModifyPerson,Customer.dModifyDate, Customer.cRelVendor, Customer.iId,Customer.cPriceGroup,Customer.cOfferGrade,
 Customer.iOfferRate,Customer.cCusDefine4, Customer.cCusDefine5, Customer.cCusDefine6,Customer.cCusDefine7, Customer.cCusDefine8, 
Customer.cCusDefine9,Customer.cCusDefine10, Customer.cCusDefine11,Customer.cCusDefine12, Customer.cCusDefine13,
Customer.cCusDefine14, Customer.cCusDefine15,Customer.cCusDefine16 , isnull(cPayCode,N'') as cPayCode, isnull(cPayName,N'') as cPayName, 
isnull(ShippingChoice.cSCCode,N'') as cSCCode,isnull(ShippingChoice.cSCName,N'') as cSCName,
 customer.cCusCreditCompany as ccreditcuscode,creditcustomer.ccusname as ccreditcusname,  isnull(customer.bCreditDate,0) as 
bCreditDate,isnull(customer.cCusSAProtocol,N'') as cCusSAProtocol ,isnull(customer.ccusotherprotocol,N'') as ccusotherprotocol,
 isnull(customer.ccusexch_name,'') as ccusexch_name  from customer  left join person on customer.cCusPPerson=person.cpersoncode left 
join department on customer.cCusDepart=department.cdepcode left join ShippingChoice on customer.cCusOType=ShippingChoice.cSCCode 
left join  PayCondition on customer.cCusPayCond=PayCondition.cPayCode left join cusdeliveradd cusadd on (cusadd.ccuscode = 
customer.ccuscode and cusadd.bdefault=1)   left join crm_contact crm on (crm.ccontactcode=cusadd.clinkperson) left join 
customer as creditcustomer on customer.cCusCreditCompany=creditcustomer.ccuscode WHERE (customer.ccusAbbName=N'贺州市富力智能科技有限公司' 
OR customer.cCusCode=N'贺州市富力智能科技有限公司')  and isnull(Customer.dEndDate,'9999-12-31')>getdate()

 SELECT isnull(Person.cPersonCode,N'') as chandler,isnull(cPersonName,N'') as cPersonName,isnull(person.cPersonCode,N'') as cpersoncode,
isnull(department.cdepcode,N'') as cdepcode,isnull(cDepName,N'') as cDepName, cusadd.cdeliveradd as cshipaddress 
,cusadd.caddcode,cusadd.cdeliverunit,crm.ccontactname ,crm.cmobilephone,crm.cofficephone, Customer.cCusCode, Customer.cCusName,
 Customer.cCusAbbName, Customer.cCCCode, Customer.cDCCode, Customer.cTrade, Customer.cCusAddress, Customer.cCusPostCode, 
Customer.cCusRegCode, Customer.cCusBank, Customer.cCusAccount, Customer.dCusDevDate, Customer.cCusLPerson,
 Customer.cCusEmail,Customer.cCusPerson, Customer.cCusPhone, Customer.cCusFax,Customer.cCusBP, Customer.cCusHand, Customer.cCusPPerson, 
Customer.iCusDisRate, Customer.cCusCreGrade, Customer.iCusCreLine,Customer.iCusCreDate, Customer.cCusPayCond,
Customer.cCusOAddress, Customer.cCusOType,Customer.cCusHeadCode, Customer.cCusWhCode,Customer.cCusDepart, Customer.iARMoney, 
Customer.dLastDate,Customer.iLastMoney, Customer.dLRDate, Customer.iLRMoney,Customer.dEndDate, Customer.iFrequency,
 Customer.cCusDefine1,Customer.cCusDefine2, Customer.cCusDefine3, Customer.iCostGrade,Customer.cCreatePerson, 
Customer.cModifyPerson,Customer.dModifyDate, Customer.cRelVendor, Customer.iId,Customer.cPriceGroup,Customer.cOfferGrade,
 Customer.iOfferRate,Customer.cCusDefine4, Customer.cCusDefine5, Customer.cCusDefine6,Customer.cCusDefine7, Customer.cCusDefine8, 
Customer.cCusDefine9,Customer.cCusDefine10, Customer.cCusDefine11,Customer.cCusDefine12, Customer.cCusDefine13,
Customer.cCusDefine14, Customer.cCusDefine15,Customer.cCusDefine16 , isnull(cPayCode,N'') as cPayCode, isnull(cPayName,N'') as cPayName, 
isnull(ShippingChoice.cSCCode,N'') as cSCCode,isnull(ShippingChoice.cSCName,N'') as cSCName,
 customer.cCusCreditCompany as ccreditcuscode,creditcustomer.ccusname as ccreditcusname,  isnull(customer.bCreditDate,0) as 
bCreditDate,isnull(customer.cCusSAProtocol,N'') as cCusSAProtocol ,isnull(customer.ccusotherprotocol,N'') as ccusotherprotocol,
 isnull(customer.ccusexch_name,'') as ccusexch_name  from customer  left join person on customer.cCusPPerson=person.cpersoncode left 
join department on customer.cCusDepart=department.cdepcode left join ShippingChoice on customer.cCusOType=ShippingChoice.cSCCode 
left join  PayCondition on customer.cCusPayCond=PayCondition.cPayCode left join cusdeliveradd cusadd on (cusadd.ccuscode = 
customer.ccuscode and cusadd.bdefault=1)   left join crm_contact crm on (crm.ccontactcode=cusadd.clinkperson) left join 
customer as creditcustomer on customer.cCusCreditCompany=creditcustomer.ccuscode WHERE (customer.ccusAbbName=N'巴西维多利亚视频科技有限公司' 
OR customer.cCusCode=N'巴西维多利亚视频科技有限公司')  and isnull(Customer.dEndDate,'9999-12-31')>getdate()

select * from SO_SOMain where csocode='H201706035692'


 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829181,95,Null,N'普通销售',Null,N'H',Null,'2017-06-07',N'H201706035692',N'2204D001',N'04',N'07090186',Null,Null,N'003',N'人民币',1,3,Null,N'上年结转',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-07','2017-06-07',0,Null,N'巴西维多利亚视频科技有限公司',0,Null,Null,Null,N'2204D001',Null,Null,0,Null,Null,0,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'H201706035692',N'10000102','2017-06-07',2,Null,0,2.915,3,5.83,.17,6,0,2.915,5.83,.17,6,0,Null,Null,Null,Null,Null,Null,N'调整开票误差',Null,Null,189449,100,100,N'片状电容',3,N'N制带客户LOGO',N'英文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829181,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-07',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)
 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,
inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,
cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,
iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,
dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,
iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,
fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035603',N'10002704','2017-06-06',1,Null,0,3,3,3,0,3,0,3,3,0,3,0,Null,Null,Null,Null,Null,Null,N'调整开票误差',Null,Null,189169,100,100,N'▼片状电容',0,N'N制带公司LOGO',N'中文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829079,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-06',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,
inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,
cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,
iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,
dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,
iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,
fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035603',N'10003000','2017-06-06',1,Null,0,4,4,4,0,4,0,4,4,0,4,0,Null,Null,Null,Null,Null,Null,N'销售出库',Null,Null,189170,100,100,N'贴片电容',0,N'P制带客户LOGO',N'俄文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829079,Null,Null,Null,N'无',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-06',2,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)
 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,
inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,
cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,
iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,
dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,
iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,
fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'W201706035604',N'10002211','2017-06-06',1,Null,0,1,1,1,0,1,0,1,1,0,1,0,Null,Null,Null,Null,Null,Null,N'期初',Null,Null,189171,100,100,N'▼贴片电容',0,N'N制带客户LOGO',N'俄文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829080,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-06',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,
inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,
cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,
iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,
dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,
iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,
fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'Z201706035605',N'0209010','2017-06-06',1,Null,0,1,1,1,0,1,0,1,1,0,1,0,Null,Null,Null,Null,Null,Null,N'国内销售收入',Null,Null,189172,100,100,N'RS-D1108OB-S后面壳模具',0,N'P制中性',N'德语',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829081,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-06',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

select * from SO_SOMain where csocode='H201706035694'
select * from SO_SOMain where csocode='G201706035695'
select* from SO_SOMain where csocode='H201706035696'
select * from SO_SOMain where csocode='G201706035700'

select* from SO_SODetails where csocode='H201706035694'
select* from SO_SODetails where csocode='H201706035696'
select* from SO_SODetails where csocode='G201706035695'

select* from SO_SODetails where csocode='G201706035698'

select * from SO_SOMain where csocode='G201706035698'

select* from SO_SODetails where csocode='2201706035701'
select* from SO_SODetails where csocode='G201706035700'




select* from SO_SODetails where csocode='Z201706035605'
select* from SO_SODetails where csocode='W201706035604'
select* from SO_SODetails where csocode='G201706035603'

select * from ForeignCurrency where cexch_name=N'美元'