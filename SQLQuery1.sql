Select * from SaleOrderQ where id=1828600

use UFDATA_559_2017


select * from SaleOrderSQ

select * from inventory

select * from SaleOrderQ

Select * from SaleOrderQ where id=1829034
Select * ,N'' as editprop From SaleOrderSQ where id = 1829034 order by irowno
select * from inventory  where cinvcode='CH3920000'

select* from InventoryClass where cInvCCode ='CBCAIP04'

select cInvCName from InventoryClass where cInvCName like '%DVR%'

select cInvCName from InventoryClass where cInvCName like '%IPC%'


select cInvCName from InventoryClass where cInvCName like '%配件%'

select cInvCName from InventoryClass where cInvCName like '%HD%'
 
select * from inventory where cinvcode='D110810064'
select  so_sodetails.autoid,so_sodetails.id,so_sodetails.cinvcode, inventory.bservice, inventory.cinvname, cinvaddcode,so_sodetails.body_outid,
	inventory.cinvstd, so_sodetails.cunitid, unit1.ccomunitname as cinvm_unit,inventory.igrouptype,inventory.cgroupcode,case when isnull(inventory.igrouptype,0)=0 then null else unit2.ccomunitname end as cinva_unit,
	inventory.cinvdefine1, inventory.cinvdefine2, inventory.cinvdefine3,inventory.cinvdefine4,inventory.cinvdefine5,inventory.cinvdefine6,inventory.cinvdefine7,inventory.cinvdefine8,inventory.cinvdefine9,
	inventory.cinvdefine10,inventory.cinvdefine11,inventory.cinvdefine12,inventory.cinvdefine13,inventory.cinvdefine14,inventory.cinvdefine15,inventory.cinvdefine16,so_sodetails.iquantity, case when igrouptype=0 then null else  cast(so_sodetails.inum as decimal(26,9))  end as inum,
	so_sodetails.iquotedprice, so_sodetails.iunitprice,iinvsprice,iinvncost, 
	so_sodetails.imoney, so_sodetails.itax, so_sodetails.isum, so_sodetails.inatunitprice, so_sodetails.inatmoney, 
	so_sodetails.inattax, so_sodetails.inatsum, so_sodetails.inatdiscount, so_sodetails.idiscount, 
	so_sodetails.ifhquantity, case when inventory.igrouptype=1 then ifhquantity/iinvexchrate else so_sodetails.ifhnum end as ifhnum, so_sodetails.ifhmoney, so_sodetails.ikpquantity, 
	so_sodetails.fsalecost,so_sodetails.fsaleprice,iexchsum,
	so_sodetails.ikpnum, so_sodetails.ikpmoney, so_sodetails.dpredate, so_sodetails.cmemo, so_sodetails.cfree1, 
	so_sodetails.cfree2, so_sodetails.iinvexchrate, inventory.iinvlscost, so_sodetails.itaxunitprice, inventory.bfree1, inventory.bfree2,  inventory.bfree3, inventory.bfree4, inventory.bfree5, inventory.bfree6, inventory.bfree7, inventory.bfree8, inventory.bfree9, inventory.bfree10,
	bsalepricefree1,bsalepricefree2,bsalepricefree3,bsalepricefree4,bsalepricefree5,bsalepricefree6,bsalepricefree7,bsalepricefree8,bsalepricefree9,bsalepricefree10,
	inventory.binvtype, so_sodetails.itaxrate, so_sodetails.kl, so_sodetails.kl2, so_sodetails.cdefine22, so_sodetails.cdefine23, 
	so_sodetails.cdefine24, so_sodetails.cdefine25, so_sodetails.cdefine26, so_sodetails.cdefine27, so_sodetails.cdefine28,so_sodetails.cdefine29,so_sodetails.cdefine30,so_sodetails.cdefine31,
	so_sodetails.cdefine32,so_sodetails.cdefine33,so_sodetails.cdefine34,so_sodetails.cdefine35,so_sodetails.cdefine36,so_sodetails.cdefine37,so_sodetails.isosid, so_sodetails.citemcode, 
	so_sodetails.citem_class,100-so_sodetails.kl as dkl1,100-so_sodetails.kl2 as dkl2,so_sodetails.citemname,so_sodetails.citem_cname,
	so_sodetails.cfree3,so_sodetails.cfree4,so_sodetails.cfree5,so_sodetails.cfree6,so_sodetails.cfree7,so_sodetails.cfree8,so_sodetails.cfree9,so_sodetails.cfree10,inventory.iid as cinvauthid,
	isnull(so_sodetails.cscloser,N'') cscloser ,so_sodetails.irowno,imoquantity,so_sodetails.icusbomid,
	case when isnull(so_sodetails.icusbomid,0)=0 then N'未选配' else N'已选配' end as cconfigstatus,inventory.ccomunitcode,
	so_sodetails.ippartseqid,so_sodetails.ippartid,so_sodetails.ippartqty,so_sodetails.dpremodate,iquoid,cquocode,inventory.cbarcode,so_sodetails.ccontractid,so_sodetails.ccontracttagcode,so_sodetails.ccontractrowguid,
	case when isnull(inventory.batomodel,0)=0 then N'否' else N'是' end as batomodel,case when isnull(inventory.bptomodel,0)=0 then N'否' else N'是' end as bptomodel,
	so_sodetails.ccusinvcode,so_sodetails.ccusinvname,fcusminprice,case when isnull(borderbom,0)=1 then N'是' else N'否' end as borderbom,case when isnull(borderbomover,0)=1 then N'是' else N'否' end  as borderbomover,idemandtype as idemandtype,cdemandcode,cdemandmemo,
	so_sodetails.iprekeepquantity,so_sodetails.iprekeeptotquantity,so_sodetails.iprekeeptotnum,case when isnull(busecusbom,0)=1 then 1 else 0 end as busecusbom,
	case when igrouptype=0 then null when igrouptype=1 then so_sodetails.iprekeepquantity /(case when isnull(iinvexchrate,0)=0 then 1 else isnull(iinvexchrate,0) end) else   so_sodetails.iprekeepnum   end as iprekeepnum ,
	case when isnull(inventory.binvmodel,0)=0 then N'否' else N'是' end as binvmodel,inventory.csrpolicy,so_sodetails.fpurquan,
	inventory.iadvancedate as iadvancedate,case when isnull(so_sodetails.dreleasedate,0)=0 then dpredate else dreleasedate end as dreleasedate,fimquantity,fomquantity,inventory.bproxyforeign,ballpurchase,bspecialorder
	,binvbatch,btrack,dedate,isnull(inventory.bproductbill,0) as bproductbill,iaoids,cpreordercode,convert(nvarchar(10),dbclosedate,121) as dbclosedate,dbclosesystime
	,inventory.iid as iinvid ,isnull(finquantity,0) as finquantity,isnull(foutquantity,0) as foutquantity ,isnull(fretquantity,0) as fretquantity,case when igrouptype=1 then isnull(fretquantity,0)/iinvexchrate else isnull(fretnum,0) end as fretnum,iimid,ccorvouchtype,vouchtype.enumname as ccorvouchtypename,icorrowno
 FROM SO_SODetails inner JOIN Inventory with (nolock) ON SO_SODetails.cInvCode = Inventory.cInvCode left join ComputationUnit as Unit1 on inventory.cComUnitCode=Unit1.cComUnitCode
 left join ComputationUnit as Unit2 on so_sodetails.cunitid=Unit2.cComUnitCode
 left join inventory_sub on inventory_sub.cinvsubcode=SO_SODetails.cinvcode
 left join AA_RequirementClass on SO_SODetails.cdemandcode=AA_RequirementClass.cRClassCode
 left join v_aa_enum vouchtype on vouchtype.enumtype=N'SA.cvouchtype' and vouchtype.enumcode=SO_SODetails.ccorvouchtype





Select * from SaleOrderQ where id=1829055

Select * ,N'' as editprop From SaleOrderSQ where id = 1829055 order by irowno



select pictureguid,'存货图片' as CFileName,1 as IOrder from inventory   where cInvCode='CH3920000' 
Union 
select AttachFileGuid,CFileName, 2 as Iorder   from Attachfile where cInvCode='CH3920000' order by IOrder


Select * from SaleOrderQ where id=1829034
Select * ,N'' as editprop From SaleOrderSQ where id = 1829034 order by irowno

select * from VoucherAccessories where VoucherTypeID='17' and VoucherID='1829034'

select sum(total) as total,max(lastprintTime) as  lastprintTime,GetDate() as CurrentServerDate 
from PrintPolicy_VCH where  vchid='H201706035582' and PolicyID like '17_%'
select isnull(idec,0) as idec from dbo.foreigncurrency where  cexch_name=N'美元'

select* from so_somain where id=1829034


select convert(char,convert(money,so_somain.ufts),2) as ufts,so_somain.id,ivtid,cchanger,cbustype,ccrechpname,so_somain.cstcode,so_somain.outid,
so_somain.ddate, so_somain.csocode, so_somain.ccuscode, so_somain.cdepcode,case when bDeliveryOverOrder=1 then 0 else 1 end as boverorder,
so_somain.cpersoncode, so_somain.csccode, so_somain.ccusoaddress, so_somain.cpaycode, 
so_somain.cexch_name, so_somain.iexchrate, so_somain.itaxrate, so_somain.imoney, so_somain.cmemo, so_somain.istatus, 
so_somain.cmaker, so_somain.cverifier, so_somain.ccloser, so_somain.cdefine1, so_somain.cdefine2, so_somain.cdefine3, 
so_somain.cdefine4, so_somain.cdefine5, so_somain.cdefine6, so_somain.cdefine7, so_somain.cdefine8, so_somain.cdefine9, 
so_somain.cdefine10,so_somain.cdefine11,so_somain.cdefine12,so_somain.cdefine13,so_somain.cdefine14,so_somain.cdefine15,
so_somain.cdefine16, so_somain.dpredatebt,so_somain.dpremodatebt,customer.cdccode,customer.ccccode,
customer.ccusabbname, department.cdepname, person.cpersonname, 
shippingchoice.cscname, paycondition.cpayname, saletype.cstname, creditunit.iarmoney, so_somain.bdisflag,so_somain.clocker,
so_somain.ccusname, customer.ccusphone,customer.ccusaddress, so_somain.breturnflag, creditunit.icuscreline ,customer.ccusdefine1,customer.ccusdefine2,
customer.ccusdefine3,customer.ccusdefine4,customer.ccusdefine5,customer.ccusdefine6,customer.ccusdefine7,customer.ccusdefine8,customer.ccusdefine9,
customer.ccusdefine10,customer.ccusdefine11,customer.ccusdefine12,customer.ccusdefine13,customer.ccusdefine14,customer.ccusdefine15,customer.ccusdefine16,
customer.iid as cauthid, SO_SOMain.ccusperson,so_somain.coppcode,cmodifier,convert(varchar(10),dmoddate,121) as dmoddate,convert(varchar(10),dverifydate,121) as dverifydate
--收货地址编码、收货单位、收货地址、收货联系人、收货联系人手机、收货单位联系人电话
,cusdeliveradd.caddcode, cusdeliveradd.cdeliverunit, customer.ccushand,hr_hi_person.cpsnophone,hr_hi_person.cpsnmobilephone,
Crm_Contact.ccontactname,Crm_Contact.cmobilephone,Crm_Contact.cofficephone,  so_somain.iflowid,cSalesProcessDescribes as cflowname
,SO_SOMain.cgatheringplan,AA_Agreement.cname as cgatheringplanname,customer.cCusCreditCompany as ccreditcuscode,creditunit.ccusname as ccreditcusname,
Customer.dEndDate,SO_SOMain.iverifystate,SO_SOMain.ireturncount,icreditstate,SO_SOMain.iswfcontrolled,isnull(customer.bCreditDate,0) as bcreditdate
,dcreatesystime,dverifysystime,dmodifysystime ,ddependdate,cchangeverifier,dchangeverifydate,dchangeverifytime,case when isnull(bcashsale,0)=1 then 1 else 0 end as bcashsale,cgathingcode
FROM SO_SOMain LEFT OUTER JOIN Customer with (nolock) ON SO_SOMain.cCusCode = Customer.cCusCode LEFT OUTER JOIN
Department ON SO_SOMain.cDepCode = Department.cDepCode LEFT OUTER JOIN
PayCondition ON SO_SOMain.cPayCode = PayCondition.cPayCode LEFT OUTER JOIN
Person ON SO_SOMain.cPersonCode = Person.cPersonCode LEFT OUTER JOIN
SaleType ON SO_SOMain.cSTCode = SaleType.cSTCode LEFT OUTER JOIN
ShippingChoice ON SO_SOMain.cSCCode = ShippingChoice.cSCCode
		LEFT join cusdeliveradd on SO_SOMain.ccuscode=CusDeliverAdd.ccuscode  and SO_SOMain.caddcode = CusDeliverAdd.caddcode 
      	LEFT JOIN Crm_Contact ON CusDeliverAdd.cLinkPerson = Crm_Contact.cContactCode  
		LEFT JOIN AA_Agreement on SO_SOMain.cgatheringplan = AA_Agreement.ccode 
		LEFT JOIN customer creditunit on creditunit.ccuscode = customer.cCusCreditCompany 
LEFT OUTER JOIN hr_hi_person ON SO_SOMain.cPersonCode = hr_hi_person.cPsn_Num 
left join sabizflow on SO_SOMain.iflowid=sabizflow.iflowid




select * from Customer
select*from [dbo].[Department]
select * from [dbo].[foreigncurrency]
select*from [dbo].[Person] 
select * from [dbo].[ShippingChoice]
select * from [dbo].[SaleType]
select* from [dbo].[SO_SOMain]



select tblkey, imageid, keydownapplytask, keyupfreetask, buttonkey, buttoncaptionresid, tooltiptextresid,isnull(buttonstyle,'0') as buttonstyle, inivisible, inienable, buttonindex,subindex, hotshift, hotkeycode, hotkeystate, editenable, buttonparas, 
downstatus,upstatus, errstatus, buttontag, grouptype from sa_toolbarconfig with (nolock) where tblkey=N'pushom' order by buttonindex,subindex

select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccusabbname,sq.cexch_name,sq.iexchrate,sq.cdepname,sq.cpersonname,
sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit,sqs.iquantity,sqs.itaxunitprice,sqs.iUnitPrice,sqs.iMoney,sqs.itax,sqs.isum,sqs.iTaxRate,sqs.isosid
 from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  1=1   And ((dDate >= N'2017-06-01') And (dDate <= N'2017-06-20')) 
and isnull(cchanger,'') = ''    order by sq.csocode ASC ;
use ufdata_559_2017


select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccuscode,sq.ccusdefine6,sq.cexch_name,sq.iexchrate,sq.cdepname,sq.cpersonname,
sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit,sqs.iquantity,sqs.itaxunitprice,sqs.iUnitPrice,sqs.iMoney,sqs.itax,sqs.isum,sqs.iTaxRate,sqs.isosid
,sqs.cinvdefine6,sqs.cinvdefine9,sqs.cdefine33,sqs.cdefine31,sqs.cdefine23,sq.ccusabbname
 from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sq.id=1829660
and isnull(cchanger,'') = ''    order by sq.csocode ASC ;




select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccuscode,sq.ccusdefine6,sq.cexch_name,sq.iexchrate,sq.iTaxRate,sq.cdepname,sq.cpersonname,sq.ccusabbname,sq.cpayname,
sq.cmaker,sq.cverifier,sq.cmemo,sq.ccusphone,sq.ccusaddress,sq.ccusdefine8,sq.ccusdefine9,sq.cscname as csccode, 
sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit,sqs.iquantity,sqs.itaxunitprice,sqs.isum,sqs.isosid
,sqs.cinvdefine6 as SQ_cinvdefine6,sqs.cinvdefine9,sqs.cdefine33,sqs.cdefine31,sqs.cdefine23,sqs.irowno,sqs.cmemo as SQ_cmemo,sqs.dpredate
 from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sq.id=1829660



select * from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sq.id=172739   

select *   from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sq.id=1829660

select * from SaleOrderQ  where id=1829660

select * from SaleOrderSQ where id=1829660

cinvdefine7
cinvdefine4

declare @n money
set @n = 8425652.157783453
select convert(varchar(100),@n,1)



       select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccuscode,sq.ccusdefine6,sq.cexch_name,sq.iexchrate,sq.iTaxRate,sq.cdepname,sq.cpersonname,sq.cpayname,  sq.cmemo,
         sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit as cinvmunit,convert(varchar(100),convert(money,sqs.iquantity),1) as iquantity 
            ,sqs.cinvdefine6 as SQ_cinvdefine6,sqs.cinvdefine9,sqs.cdefine33,sqs.cdefine31,sqs.cdefine22,sqs.cdefine23,sqs.irowno,sqs.cmemo as SQ_cmemo,convert(varchar, sqs.dpredate,111) as 'dpredate' ,sqs.cinvdefine7,sqs.cinvdefine4,sqs.cfree4
             from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sq.id=1829660 order by irowno 



select convert(varchar(100),convert(money,8425652.157783453),1) as iquantity


 select convert(varchar(100),,2) as iquantity

select convert(varchar(100),convert(varchar,convert(money,8425652.157783453),2),1)
select convert(varchar,convert(money,8425652.157783453),1)





select '' as 
selcol,breturnflag,cbustype,cstcode,cstname,csocode,irowno,ddate,ccuscode,ccusabbname,ccusname,cexch_name,iexchrate,cquocode,ccontractid,ccontracttagcode,coppcode,cdepcode,cdepname,cpersoncode,cpersonname,cmaker,cverifier,clocker,cchanger,ccloser,cinvcode,cinvaddcode,cinvname,ccusinvcode,ccusinvname,icusbomid,cconfigstatus,cinvstd,cgroupcode,igrouptype,cinvm_unit,iquantity,iinvexchrate,cunitid,cinva_unit,inum,iquotedprice,itaxunitprice,iunitprice,(SaleOrderSQ.iMoney) 
as imoney,itax,isum,(SaleOrderSQ.iTaxRate) as itaxrate,inatunitprice,inatmoney,inattax,inatsum,iinvlscost,kl,kl2,dkl1,dkl2,idiscount,inatdiscount,fsalecost,fsaleprice,dpremodate,dpredate,ifhquantity,ifhnum,ifhmoney,ikpquantity,(cast(case when igrouptype=1 then 
isnull(ikpquantity,0)/iinvexchrate else isnull(ikpnum,0) end as decimal(26,9))) as ikpnum,ikpmoney,fomquantity,imoquantity,(fimquantity) as fimquantity,cscloser,(SaleOrderQ.iTaxRate) as headtaxrate,(SaleOrderQ.iMoney) as headmoney,ccrechpname,(ccreditcuscode) as 
ccreditcuscode,finquantity,foutquantity,(ccreditcusname) as ccreditcusname,icuscreline,iarmoney,cpaycode,cpayname,(cgatheringplan) as cgatheringplan,(cgatheringplanname) as cgatheringplanname,csccode,cscname,ccusphone,(cdeliverunit) as 
cdeliverunit,(ccontactname) as ccontactname,(cmobilephone) as cmobilephone,(cofficephone) as cofficephone,(caddcode) as caddcode,ccusoaddress,(SaleOrderQ.cMemo) as headmemo,citem_class,citem_cname,citemcode,citemname,ccushand,(SaleOrderSQ.cMemo) as 
cmemo,icreditstate,ireturncount,iverifystate,iswfcontrolled,cfree1,cfree2,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,cinvdefine1,cinvdefine2,cinvdefine3,ccusperson,cinvdefine4,cinvdefine5,cinvdefine6,cinvdefine7,cinvdefine8,cinvdefine9,cinvdefine10,cinvdefine11,cinvdefine12,cinvdefine13,cinvdefine14,cinvdefine15,cinvdefine16,cdefine1,cdefine2,cdefine3,cdefine4,cdefine5,ufts,cdefine6,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,ivtid,cdefine16,cdefine22,cdefine23,cdefine24,cdefine25,(SaleOrderQ.ID) 
as 
id,cdefine26,cdefine27,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,cdefine36,cdefine37,ccusdefine1,ccusdefine2,ccusdefine3,ccusdefine4,ccusdefine5,ccusdefine6,ccusdefine7,ccusdefine8,ccusdefine9,ccusdefine10,ccusdefine11,ccusdefine12,ccusdefine13,ccusdefine14,ccusdefine15,ccusdefine16,isosid,(dreleasedate) 
as dreleasedate,(isnull(inum,0)-isnull(ifhnum,0)) as WFJS,(cast(isnull(inum,0)-case when igrouptype=1 then (isnull(ikpquantity,0)/iinvexchrate) else isnull(ikpnum,0) end as decimal(26,9))) as WKJS,(cchangeverifier) as cchangeverifier,(busecusbom) as 
busecusbom,(bcashsale) as bcashsale,(cflowname) as cflowname,(cgathingcode) as cgathingcode,(dchangeverifydate) as dchangeverifydate,(dchangeverifytime) as 
dchangeverifytime,cmodifier,dmoddate,dverifydate,dcreatesystime,dverifysystime,dmodifysystime,(iprekeepquantity) as iprekeepquantity,(cast(isnull(iquantity,0)-isnull(ifhquantity,0) as decimal(26,9))) as WFSL,(cast(case when isnull(iquantity,0)=0 then 
isnull(isum,0)-isnull(ifhmoney,0) else (isnull(iquantity,0)-isnull(ifhquantity,0))*itaxunitprice end as decimal(26,9))) as WFJE,(cast(isnull(iquantity,0)-isnull(ikpquantity,0) as decimal(26,9))) as WKSL,(cast(case when isnull(iquantity,0)=0 then 
isnull(isum,0)-isnull(ikpmoney,0) else (isnull(iquantity,0)-isnull(ikpquantity,0))*itaxunitprice end as decimal(26,9))) as WKJE,FPurQuan,(cast(isnull(iquantity,0)-isnull(FPurQuan,0) as decimal(26,9))) as WXDCGL,(case when isnull(bAtoModel,0)=N'是' and 
Isnull(cBusType,N'')<>N'直运销售' then cast(isnull(iquantity,0)-isnull(iprekeepquantity,0)-isnull(imoquantity,0)-isnull(fomquantity,0)+isnull(finquantity,0) as decimal(26,9)) else 0 end) as WXDSCL,(case when isnull(bAtoModel,0)=N'是' and 
Isnull(cBusType,N'')<>N'直运销售' then cast(isnull(iquantity,0)-isnull(iprekeepquantity,0)-isnull(imoquantity,0)-isnull(fomquantity,0)+isnull(finquantity,0) as decimal(26,9)) else 0 end) as WXDWWL,(cast(isnull(iquantity,0)-isnull(fimquantity,0) as 
decimal(26,9))) as WXDJKL,(fretnum) as fretnum,(fretquantity) as fretquantity,(idemandtype) as idemandtype,dbclosedate,dbclosesystime,(cpreordercode) as cpreordercode,(cdemandcode) as cdemandcode,(cdemandmemo) as cdemandmemo,(borderbom) as 
borderbom,(borderbomover) as borderbomover,(cCorVouchType) as cCorVouchType,(cCorVouchTypeName) as cCorVouchTypeName,(iCorRowNo) as iCorRowNo,istatus from #divTable19B4E1B1885B48E3B9458F229647D94D Inner Join SaleOrderQ inner join SaleOrderSQ on 
SaleOrderQ.id=SaleOrderSQ.id On #divTable19B4E1B1885B48E3B9458F229647D94D.tmpPrimaryID = SaleOrderSQ.isosid where divID>0 and divID<=500  order by csocode ASC 





select '' as 
selcol,breturnflag,cbustype,cstcode,cstname,csocode,irowno,ddate,ccuscode,ccusabbname,ccusname,cexch_name,iexchrate,cquocode,ccontractid,ccontracttagcode,coppcode,cdepcode,cdepname,cpersoncode,cpersonname,cmaker,cverifier,clocker,cchanger,ccloser,cinvcode,cinvaddcode,cinvname,ccusinvcode,ccusinvname,icusbomid,cconfigstatus,cinvstd,cgroupcode,igrouptype,cinvm_unit,iquantity,iinvexchrate,cunitid,cinva_unit,inum,iquotedprice,itaxunitprice,iunitprice,(SaleOrderSQ.iMoney) 
as imoney,itax,isum,(SaleOrderSQ.iTaxRate) as itaxrate,inatunitprice,inatmoney,inattax,inatsum,iinvlscost,kl,kl2,dkl1,dkl2,idiscount,inatdiscount,fsalecost,fsaleprice,dpremodate,dpredate,ifhquantity,ifhnum,ifhmoney,ikpquantity,(cast(case when igrouptype=1 then 
isnull(ikpquantity,0)/iinvexchrate else isnull(ikpnum,0) end as decimal(26,9))) as ikpnum,ikpmoney,fomquantity,imoquantity,(fimquantity) as fimquantity,cscloser,(SaleOrderQ.iTaxRate) as headtaxrate,(SaleOrderQ.iMoney) as headmoney,ccrechpname,(ccreditcuscode) as 
ccreditcuscode,finquantity,foutquantity,(ccreditcusname) as ccreditcusname,icuscreline,iarmoney,cpaycode,cpayname,(cgatheringplan) as cgatheringplan,(cgatheringplanname) as cgatheringplanname,csccode,cscname,ccusphone,(cdeliverunit) as 
cdeliverunit,(ccontactname) as ccontactname,(cmobilephone) as cmobilephone,(cofficephone) as cofficephone,(caddcode) as caddcode,ccusoaddress,(SaleOrderQ.cMemo) as headmemo,citem_class,citem_cname,citemcode,citemname,ccushand,(SaleOrderSQ.cMemo) as 
cmemo,icreditstate,ireturncount,iverifystate,iswfcontrolled,cfree1,cfree2,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,cinvdefine1,cinvdefine2,cinvdefine3,ccusperson,cinvdefine4,cinvdefine5,cinvdefine6,cinvdefine7,cinvdefine8,cinvdefine9,cinvdefine10,cinvdefine11,cinvdefine12,cinvdefine13,cinvdefine14,cinvdefine15,cinvdefine16,cdefine1,cdefine2,cdefine3,cdefine4,cdefine5,ufts,cdefine6,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,ivtid,cdefine16,cdefine22,cdefine23,cdefine24,cdefine25,(SaleOrderQ.ID) 
as 
id,cdefine26,cdefine27,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,cdefine36,cdefine37,ccusdefine1,ccusdefine2,ccusdefine3,ccusdefine4,ccusdefine5,ccusdefine6,ccusdefine7,ccusdefine8,ccusdefine9,ccusdefine10,ccusdefine11,ccusdefine12,ccusdefine13,ccusdefine14,ccusdefine15,ccusdefine16,isosid,(dreleasedate) 
as dreleasedate,(isnull(inum,0)-isnull(ifhnum,0)) as WFJS,(cast(isnull(inum,0)-case when igrouptype=1 then (isnull(ikpquantity,0)/iinvexchrate) else isnull(ikpnum,0) end as decimal(26,9))) as WKJS,(cchangeverifier) as cchangeverifier,(busecusbom) as 
busecusbom,(bcashsale) as bcashsale,(cflowname) as cflowname,(cgathingcode) as cgathingcode,(dchangeverifydate) as dchangeverifydate,(dchangeverifytime) as 
dchangeverifytime,cmodifier,dmoddate,dverifydate,dcreatesystime,dverifysystime,dmodifysystime,(iprekeepquantity) as iprekeepquantity,(cast(isnull(iquantity,0)-isnull(ifhquantity,0) as decimal(26,9))) as WFSL,(cast(case when isnull(iquantity,0)=0 then 
isnull(isum,0)-isnull(ifhmoney,0) else (isnull(iquantity,0)-isnull(ifhquantity,0))*itaxunitprice end as decimal(26,9))) as WFJE,(cast(isnull(iquantity,0)-isnull(ikpquantity,0) as decimal(26,9))) as WKSL,(cast(case when isnull(iquantity,0)=0 then 
isnull(isum,0)-isnull(ikpmoney,0) else (isnull(iquantity,0)-isnull(ikpquantity,0))*itaxunitprice end as decimal(26,9))) as WKJE,FPurQuan,(cast(isnull(iquantity,0)-isnull(FPurQuan,0) as decimal(26,9))) as WXDCGL,(case when isnull(bAtoModel,0)=N'是' and 
Isnull(cBusType,N'')<>N'直运销售' then cast(isnull(iquantity,0)-isnull(iprekeepquantity,0)-isnull(imoquantity,0)-isnull(fomquantity,0)+isnull(finquantity,0) as decimal(26,9)) else 0 end) as WXDSCL,(case when isnull(bAtoModel,0)=N'是' and 
Isnull(cBusType,N'')<>N'直运销售' then cast(isnull(iquantity,0)-isnull(iprekeepquantity,0)-isnull(imoquantity,0)-isnull(fomquantity,0)+isnull(finquantity,0) as decimal(26,9)) else 0 end) as WXDWWL,(cast(isnull(iquantity,0)-isnull(fimquantity,0) as 
decimal(26,9))) as WXDJKL,(fretnum) as fretnum,(fretquantity) as fretquantity,(idemandtype) as idemandtype,dbclosedate,dbclosesystime,(cpreordercode) as cpreordercode,(cdemandcode) as cdemandcode,(cdemandmemo) as cdemandmemo,(borderbom) as 
borderbom,(borderbomover) as borderbomover,(cCorVouchType) as cCorVouchType,(cCorVouchTypeName) as cCorVouchTypeName,(iCorRowNo) as iCorRowNo,istatus from #divTable19B4E1B1885B48E3B9458F229647D94D Inner Join SaleOrderQ inner join SaleOrderSQ on 
SaleOrderQ.id=SaleOrderSQ.id On #divTable19B4E1B1885B48E3B9458F229647D94D.tmpPrimaryID = SaleOrderSQ.isosid where divID>0 and divID<=500  order by csocode ASC 



































































