SELECT csocode FROM SO_SOMain WHERE csocode=N'G201706035702' and id<>1829202

SELECT csocode FROM SO_SOMain WHERE csocode=N'G201706035702' and id<>1829202

sELECT * FROM SO_SOMain with (nolock) WHERE 1=0

 Update SO_SOMain SET 
id=1829202,ivtid=95,cbustype=N'普通销售',cstcode=N'G',ddate='2017-06-08',csocode=N'G201706035702',ccuscode=N'00000004',cdepcode=N'050201',cpersoncode=N'07090070',
cpaycode=N'003',cexch_name=N'人民币',iexchrate=1,itaxrate=2,cmemo=N'国内销售收入',cmaker=N'张振初',
dpredatebt='2017-06-08T00:00:00',dpremodatebt='2017-06-08T00:00:00',bdisflag=0,ccusname=N'珠海市香洲信达智能电子产品商行',
breturnflag=0,ccusperson=N'陈旭文',iverifystate=0,iswfcontrolled=0,dcreatesystime='2017-06-08T16:20:19',bcashsale=0,
ccrechpname=Null,cmodifier=N'张振初',dmoddate='2017-06-08',dmodifysystime=getdate(),cgatheringplan=Null,caddcode=Null,ccusoaddress=Null,csccode=Null,iflowid=Null 
Where  ID= 1829202 AND convert(char, convert(money,ufts), 2)= N'562021.5549'

select* from SO_SOMain   where id= 1829202
select * from SO_SOMain where csocode='G201706035701'



 Update SO_SODetails SET 
cinvcode=N'10000104',dpredate='2017-06-08',iquantity=2,inum=Null,iquotedprice=0,iunitprice=0,itaxunitprice=0,imoney=0,itax=0,isum=0,idiscount=0,inatunitprice=0,inatmoney=0,inattax=0,inatsum=0,inatdiscount=0,cmemo=N'计提本月工资',cfree1=Null,cfree2=Null,isosid=189479,kl=100,kl2=100,cinvname=N'贴片电容',itaxrate=2,cdefine22=N'P制带客户LOGO',cdefine23=N'俄文',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,iinvexchrate=Null,cunitid=Null,id=1829202,cdefine31=N'客户LOGO',cdefine33=N'无',fsalecost=0,fsaleprice=0,cscloser=Null,dpremodate='2017-06-08',irowno=1,icusbomid=Null,ccusinvcode=Null,ccusinvname=Null,dreleasedate='2017-06-08',fcusminprice=0,ballpurchase=0,finquantity=0,foutquantity=0,fretquantity=0,fretnum=0,borderbom=0,borderbomover=0,idemandtype=Null,cdemandcode=Null,cdemandmemo=Null,busecusbom=0,cSOCode=N'G201706035702' 
Where  iSOsID= 189479
 Update SO_SODetails SET 
cinvcode=N'10000107',dpredate='2017-06-08',iquantity=32,inum=Null,iquotedprice=0,iunitprice=0,itaxunitprice=0,imoney=0,itax=0,isum=0,idiscount=0,inatunitprice=0,inatmoney=0,inattax=0,inatsum=0,inatdiscount=0,cmemo=N'销售出库',cfree1=Null,cfree2=Null,isosid=189480,kl=100,kl2=100,cinvname=N'▼贴片电容',itaxrate=2,cdefine22=N'N制带客户LOGO',cdefine23=N'英文',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,iinvexchrate=Null,cunitid=Null,id=1829202,cdefine31=N'带公司LOGO',cdefine33=N'无',fsalecost=0,fsaleprice=0,cscloser=Null,dpremodate='2017-06-08',irowno=2,icusbomid=Null,ccusinvcode=Null,ccusinvname=Null,dreleasedate='2017-06-08',fcusminprice=0,ballpurchase=0,finquantity=0,foutquantity=0,fretquantity=0,fretnum=0,borderbom=0,borderbomover=0,idemandtype=Null,cdemandcode=Null,cdemandmemo=Null,busecusbom=0,cSOCode=N'G201706035702' 
Where  iSOsID= 189480
 Update SO_SODetails SET 
cinvcode=N'10000114',dpredate='2017-06-08',iquantity=34,inum=Null,iquotedprice=0,iunitprice=0,itaxunitprice=0,imoney=0,itax=0,isum=0,idiscount=0,inatunitprice=0,inatmoney=0,inattax=0,inatsum=0,inatdiscount=0,cmemo=N'销售出库',cfree1=Null,cfree2=Null,isosid=189481,kl=100,kl2=100,cinvname=N'贴片陶瓷电容',itaxrate=2,cdefine22=N'N制带客户LOGO',cdefine23=N'德语',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,iinvexchrate=Null,cunitid=Null,id=1829202,cdefine31=N'无',cdefine33=N'有',fsalecost=0,fsaleprice=0,cscloser=Null,dpremodate='2017-06-08',irowno=3,icusbomid=Null,ccusinvcode=Null,ccusinvname=Null,dreleasedate='2017-06-08',fcusminprice=0,ballpurchase=0,finquantity=0,foutquantity=0,fretquantity=0,fretnum=0,borderbom=0,borderbomover=0,idemandtype=Null,cdemandcode=Null,cdemandmemo=Null,busecusbom=0,cSOCode=N'G201706035702' 
Where  iSOsID= 189481


update bom_orderbom set orderseq=irowno from bom_orderbom inner join so_sodetails on bom_orderbom.OrderDId=so_sodetails.isosid where OrderType=1 and id= 1829202

Update customer set bCusState =1 where ccuscode=N'00000004' AND ISNULL(bCusState,0)=0

update so_sodetails set csocode='G201706035702' where id=1829202

select MakeVoucherRuleID from UAP_MakeVoucherIndex with(nolock) where [CardNumber]= '17'and [PrimaryValue]='1829202'

Select * from SaleOrderQ where id=1829202

Select * ,N'' as editprop From SaleOrderSQ where id = 1829202 order by irowno

select sum(total) as total,max(lastprintTime) as  lastprintTime,GetDate() as CurrentServerDate from PrintPolicy_VCH where  vchid='G201706035702' and PolicyID like '17_%'

select * from SO_SODetails where csocode='H201706035705'
select * from SO_SOMain where csocode='H201706035705'

select* from SO_SODetails where  iSOsID=189488 csocode='G201706035703'
use UFdata_559_2017



Select *  from SaleOrderQ  order by id desc 

Select top 1 * from SaleOrderQ  where id=0 order by id desc 

Select * ,N'' as editprop From SaleOrderSQ where id = 0 order by irowno


select *  from SO_SODetails where id =1829210

select * into zhrs_t_CopySO_SODetails from SO_SODetails  where id =1829210


select * from zhrs_t_CopySO_SODetails from 

alter table zhrs_t_CopySO_SODetails add userid int

delete from zhrs_t_CopySO_SODetails
drop table zhrs_t_CopySaleOrderSQ


select * from SO_SODetails where id =1829210
select* from zhrs_t_CopySO_SODetails
select * from SaleOrdersQ where id =1829210


insert into zhrs_t_CopySO_SODetails(id,irowNo,cInvCode,iSOsID)
values(1829210,2,'','')

--insert into SO_SODetails(id,irowNo,cInvCode,iSOsID)values(1829210,5,'','')



select * from  zhrs_t_CopySO_SODetails order by irowNo where userid=5 and 


 

update SO_SODetails set iRowNo=iRowNo-1 where iRowNo>=3 and Id=1829210
select * from SO_SODetails where id =1829210
select *  from SaleOrderSQ  where id =1829210
select * from zhrs_t_CopySaleOrderSQ where id =1829210 order by irowNo


update SO_SODetails set iRowNo=iRowNo-1 where iRowNo=4 and Id=1829210


select  * from SO_SODetails  where id =1829209 order by iRowNo
select * from  zhrs_t_CopySaleOrderSQ1 order by iRowNo


select irowNo from SO_SODetails where id = 1829209 and isosid =189706


G201706035740

select* from SO_SODetails where id = 1829274

insert into zhrs_t_CopySaleOrderSQ1 select * from SaleOrderSQ where id =1829209

delete from  SO_SODetails where isosid= 189703

delete  from zhrs_t_CopySaleOrderSQ1 where irowNo=2

select * from zhrs_t_CopySaleOrderSQ1

update SO_SODetails set iRowNo=iRowNo-1 where iRowNo>=3 and Id=1829210

insert into zhrs_t_CopySaleOrderSQ1(iRowNo)
values (2)



if object_id('zhrs_t_CopySaleOrderSQ1')is not null
drop table zhrs_t_CopySaleOrderSQ1
go
create table zhrs_t_CopySaleOrderSQ1
(
  autoid varchar(300)null,
  id varchar(300)null,
  cinvcode varchar(300)null,
  bservice varchar(300)null,
  cinvname varchar(300)null,
  cinvaddcode varchar(300)null,
    body_outid varchar(300)null,
  cinvstd varchar(300)null,
  cunitid varchar(300)null,
  cinvm_unit varchar(300)null,
  igrouptype varchar(300)null,
  cgroupcode varchar(300)null,
  cinva_unit varchar(300)null,
cinvdefine1 varchar(300)null,
cinvdefine2 varchar(300)null,
cinvdefine3 varchar(300)null,
cinvdefine4 varchar(300)null,
cinvdefine5 varchar(300)null,
cinvdefine6 varchar(300)null,
cinvdefine7 varchar(300)null,
cinvdefine8 varchar(300)null,
cinvdefine9 varchar(300)null,
cinvdefine10 varchar(300)null,
cinvdefine11 varchar(300)null,
cinvdefine12 varchar(300)null,
cinvdefine13 varchar(300)null,
cinvdefine14 varchar(300)null,
cinvdefine15 varchar(300)null,
cinvdefine16 varchar(300)null,
iquantity varchar(300)null,
inum varchar(300)null,
iquotedprice varchar(300)null,
iunitprice varchar(300)null,
iinvsprice varchar(300)null,
iinvncost varchar(300)null,
imoney varchar(300)null,
itax varchar(300)null,
isum varchar(300)null,
inatunitprice varchar(300)null,
inatmoney varchar(300)null,
inattax varchar(300)null,
inatsum varchar(300)null,
inatdiscount varchar(300)null,
idiscount varchar(300)null,
ifhquantity varchar(300)null,
ifhnum varchar(300)null,
ifhmoney varchar(300)null,
ikpquantity varchar(300)null,
fsalecost varchar(300)null,
fsaleprice varchar(300)null,
iexchsum varchar(300)null,
ikpnum varchar(300)null,
ikpmoney varchar(300)null,
dpredate varchar(300)null,
cmemo varchar(300)null,
cfree1 varchar(300)null,
cfree2 varchar(300)null,
iinvexchrate varchar(300)null,
iinvlscost varchar(300)null,
itaxunitprice varchar(300)null,
bfree1 varchar(300)null,
bfree2 varchar(300)null,
bfree3 varchar(300)null,
bfree4 varchar(300)null,
bfree5 varchar(300)null,
bfree6 varchar(300)null,
bfree7 varchar(300)null,
bfree8 varchar(300)null,
bfree9 varchar(300)null,
bfree10 varchar(300)null,
bsalepricefree1 varchar(300)null,
bsalepricefree2 varchar(300)null,
bsalepricefree3 varchar(300)null,
bsalepricefree4 varchar(300)null,
bsalepricefree5 varchar(300)null,
bsalepricefree6 varchar(300)null,
bsalepricefree7 varchar(300)null,
bsalepricefree8 varchar(300)null,
bsalepricefree9 varchar(300)null,
bsalepricefree10 varchar(300)null,
binvtype varchar(300)null,
itaxrate varchar(300)null,
kl varchar(300)null,
kl2 varchar(300)null,
cdefine22 varchar(300)null,
cdefine23 varchar(300)null,
cdefine24 varchar(300)null,
cdefine25 varchar(300)null,
cdefine26 varchar(300)null,
cdefine27 varchar(300)null,
cdefine28 varchar(300)null,
cdefine29 varchar(300)null,
cdefine30 varchar(300)null,
cdefine31 varchar(300)null,
cdefine32 varchar(300)null,
cdefine33 varchar(300)null,
cdefine34 varchar(300)null,
cdefine35 varchar(300)null,
cdefine36 varchar(300)null,
cdefine37 varchar(300)null,
isosid varchar(300)null,
citemcode varchar(300)null,
citem_class varchar(300)null,
dkl1 varchar(300)null,
dkl2 varchar(300)null,
citemname varchar(300)null,
citem_cname varchar(300)null,
cfree3 varchar(300)null,
cfree4 varchar(300)null,
cfree5 varchar(300)null,
cfree6 varchar(300)null,
cfree7 varchar(300)null,
cfree8 varchar(300)null,
cfree9 varchar(300)null,
cfree10 varchar(300)null,
cinvauthid varchar(300)null,
cscloser varchar(300)null,
irowno int null,
imoquantity varchar(300)null,
icusbomid varchar(300)null,
cconfigstaus varchar(300)null,
ccomunitcode varchar(300)null,
ippartseqid varchar(300)null,
ippartid varchar(300)null,
ippartqty varchar(300)null,
dpremodate varchar(300)null,
iquoid varchar(300)null,
cquocode varchar(300)null,
cbarcode varchar(300)null,
ccontractid varchar(300)null,
ccontracttagcode varchar(300)null,
ccontractrowguid varchar(300)null,
batomodel varchar(300)null,
bptomodel varchar(300)null,
ccusinvcode varchar(300)null,
ccusinvname varchar(300)null,
fcuminprice varchar(300)null,
borderbom varchar(300)null,
borderbomover varchar(300)null,
idemandtype varchar(300)null,
cdemandcode varchar(300)null,
cdemandmemo varchar(300)null,
iprekeepquantity varchar(300)null,
iprekeeptotquantity varchar(300)null,
iprekeeptotnum varchar(300)null,
busecusbom varchar(300)null,
iprekeepnum varchar(300)null,
binvmodel varchar(300)null,
csrpolicy varchar(300)null,
fpurquan varchar(300)null,
iadvancedate varchar(300)null,
dreleasedate varchar(300)null,
fimquantity varchar(300)null,
fomquantity varchar(300)null,
bproxyforeign varchar(300)null,
ballpurchase varchar(300)null,
bspercialorder varchar(300)null,
binvbatch varchar(300)null,
btrack varchar(300)null,
dedate varchar(300)null,
bproductbill varchar(300)null,
iaoid varchar(300)null,
cpreordercode varchar(300)null,
dbclosedate varchar(300)null,
dbclosesystime varchar(300)null,
iinvid varchar(300)null,
finquantity varchar(300)null,
foutquantity varchar(300)null,
fretquantity varchar(300)null,
fretnum varchar(300)null,
iimid varchar(300)null,
ccorvouchtype varchar(300)null,
ccorvouchtypename varchar(300)null,
icorrowno varchar(300)null,
)












delete  from zhrs_t_CopySaleOrderSQ where  autoid=104336













select * from SO_SOMain where csocode='H201706035719'

update SO_SODetails set iRowNo=iRowNo+1 where iRowNo>=2 and Id=1829210

delete from SO_SODetails where cinvcode='40700262' and autoId=104334

declare @p5 int
set @p5=0
declare @p6 int
set @p6=0
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6



 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,
inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,
cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,
cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,
ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,
fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,
cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'',N'40700262','',null,Null,null,null,null,null,null,null,null,null,null,null,null,null,Null,Null,Null,Null,Null,
Null,Null,Null,Null,189674,100,100,N'',0,N'',N'',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,
Null,Null,1829210,Null,Null,Null,N'',Null,N'',Null,Null,Null,0,0,Null,Null,Null,'',2,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,
Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,1,0,1,N'Systemdefault',N'系统默认分类',Null,Null,Null,0,Null)

select  * from SO_SODetails  where id =1829210 order by iRowNo




 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'',N'','',null,Null,null,null,null,null,null,null,null,null,null,null,null,null,Null,Null,Null,Null,Null,Null,Null,Null,Null,189670,100,100,N'DVR天线',0,N'P制带客户LOGO',N'葡萄牙',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829209,Null,Null,Null,N'无',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-09',8,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,1,0,1,N'Systemdefault',N'系统默认分类',Null,Null,Null,0,Null)

use ufdata_559_2017

select* from SO_SOMain where id =1829209
select  * from SO_SODetails  where id =1829209 order by iRowNo
select * from  zhrs_t_CopySaleOrderSQ1 order by iRowNo

delete from  SO_SODetails where autoid=104336

select * from SaleOrderQ where id =1829210
select * from SaleOrderSQ where    cinvcode='40700262'--id =1829210



Select bInvType,bService,cInvCode,iGroupType,cGroupCode,isnull(iinvlscost,'') as iinvlscost ,bfree1,bconfigfree1,bfree2,bconfigfree2,bfree3,bconfigfree3,bfree4,bconfigfree4,bfree5,bconfigfree5,bfree6,bconfigfree6,bfree7,bconfigfree7,bfree8,bconfigfree8,bfree9,bconfigfree9,bfree10,bconfigfree10 
from Inventory with (nolock) where cInvCode=N'10000104' and bSale<>0 and isnull(dEDate,'9999-12-31')>'2017-06-14'

SELECT csocode FROM SO_SOMain WHERE csocode=N'G201706035740' and id<>0


 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829274,95,Null,N'普通销售',Null,N'G',Null,'2017-06-14',N'G201706035740',N'00000005',N'050201',N'07090070',Null,Null,N'002',N'人民币',1,0,Null,N'备用金',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-14','2017-06-14',0,Null,N'长春市城北锅炉配套厂',0,N'刘刚',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035740',N'10000104','2017-06-17',2,Null,0,1.96,2,3.92,.08,4,0,1.96,3.92,.08,4,0,Null,Null,Null,Null,Null,Null,Null,Null,Null,189707,100,100,N'贴片电容',2,N'N制带客户LOGO',N'俄文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829274,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-16',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)
 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035740',N'10001504','2017-06-24',3,Null,0,1.96,2,5.88,.12,6,0,1.96,5.88,.12,6,0,Null,Null,Null,Null,Null,Null,Null,Null,Null,189708,100,100,N'贴片电容',2,N'N制带客户LOGO',N'英文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829274,Null,Null,Null,Null,Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-17',2,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)









 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'H201706035718',N'16200365','2017-06-09',20,Null,0,12,12,240,0,240,0,81.708,1634.16,0,1634.16,0,Null,Null,Null,Null,Null,Null,Null,Null,Null,189669,100,100,N'DVR按键板',0,N'N制带客户LOGO',N'意大利文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829209,Null,Null,Null,N'无',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-09',6,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)


 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'H201706035718',N'18080340K','2017-06-09',3,Null,0,2,2,6,0,6,0,13.618,40.85,0,40.85,0,Null,Null,Null,Null,Null,Null,Null,Null,Null,189670,100,100,N'DVR天线',0,N'P制带客户LOGO',N'葡萄牙',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829209,Null,Null,Null,N'无',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-09',8,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,1,0,1,N'Systemdefault',N'系统默认分类',Null,Null,Null,0,Null)







 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829276,95,Null,N'普通销售',Null,N'H',Null,'2017-06-14',N'H201706035741',N'00000012',N'050201',N'07090070',Null,Null,N'003',N'人民币',1,2,Null,N'销售出库',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-14','2017-06-14',0,Null,N'广州市富利邦资讯有限公司',0,N'何少明',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)

 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'H201706035741',N'10000105','2017-06-14',2,Null,0,2.94,3,5.88,.12,6,0,2.94,5.88,.12,6,0,Null,Null,Null,Null,Null,Null,Null,Null,Null,189710,100,100,N'贴片电容',2,N'N制中性',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829276,Null,Null,Null,Null,Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-14',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)

select * from SO_SODetails where csocode='H201706035741'



select * from zhrs_t_CopySaleOrderSQ1 where id=1829276
update SO_SODetails set iRowNo=iRowNo-1 where iRowNo=4 and autoid=104347  and Id=1829276

update SO_SODetails set iRowNo=iRowNo where isosid=isosid and Id=Id

select * from SaleOrderSQ where id=1829276








































