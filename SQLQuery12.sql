select * from VoucherAccessories where VoucherTypeID='17' and VoucherID='0'
use UFDATA_559_2017
H201706035600
G201706035600
南宁市宇盾电子科技有限公司

Select cpaycode,cpayname from PayCondition where cPayName=N'n/60' Or cPayCode=N'n/60'
cCusCode as'客户编码',cCusAbbName as '客户简称',
select * from  Customer  (NOLOCK)where cCusAbbName='广州永创电子科技有限公司'

exec sp_reset_connection 

EXEC sp_executesql N'SELECT TOP 100  cast(0 as bit) as bRefSelectColumn,[ST_GL_bdigestEntity_GL_bdigest].[cid] as cid,[ST_GL_bdigestEntity_GL_bdigest].[ctext] as ctext,[ST_GL_bdigestEntity_GL_bdigest].[ccode] as ccode 
FROM [GL_bdigest] AS [ST_GL_bdigestEntity_GL_bdigest]
Order by cid ASC ',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'

EXEC sp_executesql N'Select [InventoryClass_InventoryClass].[cInvCCode],[InventoryClass_InventoryClass].[cInvCName]
 FROM [InventoryClass] AS [InventoryClass_InventoryClass]
order by cInvCCode ASC ',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'

EXEC sp_executesql N'SELECT TOP 100  cast(0 as bit) as bRefSelectColumn,'''' as SelCol,[InventoryEntity_Inventory].[cInvCode] as cInvCode,[InventoryEntity_Inventory].[cInvName] as cInvName,[InventoryEntity_Inventory].[cInvStd] as cInvStd,[InventoryEntity_Inventory].[cInvAddCode] as 
cInvAddCode,[InventoryEntity_Inventory].[cInvABC] as cInvABC,[InventoryEntity_Inventory].[dSDate] as dSDate,[InventoryEntity_ComputationGroup].[cGroupName] as cGroupName,[InventoryEntity_ComputationUnit].[cComUnitName] as cComUnitName 
FROM [Inventory] AS [InventoryEntity_Inventory]
LEFT JOIN [ComputationGroup] AS [InventoryEntity_ComputationGroup] ON  [InventoryEntity_ComputationGroup].[cGroupCode] = [InventoryEntity_Inventory].[cGroupCode]
LEFT JOIN [ComputationUnit] AS [InventoryEntity_ComputationUnit] ON  [InventoryEntity_ComputationUnit].[cComunitCode] = [InventoryEntity_Inventory].[cComUnitCode]
WHERE 1=1  and ([InventoryEntity_Inventory].[cInvCCode] like @treeViewClsCode ) and (bsale=1  and isnull(dEDate,N''9999-12-31'')>N''2017-06-05'')
 Order by cInvCode ASC  SELECT COUNT(*) AS [ROWCOUNT] FROM (Select cast(0 as bit) as bRefSelectColumn,'''' as SelCol,[InventoryEntity_Inventory].[cInvCode] as cInvCode,[InventoryEntity_Inventory].[cInvName] as cInvName,[InventoryEntity_Inventory].[cInvStd] as cInvStd,[InventoryEntity_Inventory].[cInvAddCode] 
as cInvAddCode,[InventoryEntity_Inventory].[cInvABC] as cInvABC,[InventoryEntity_Inventory].[dSDate] as dSDate,[InventoryEntity_ComputationGroup].[cGroupName] as cGroupName,[InventoryEntity_ComputationUnit].[cComUnitName] as cComUnitName
FROM [Inventory] AS [InventoryEntity_Inventory]
LEFT JOIN [ComputationGroup] AS [InventoryEntity_ComputationGroup] ON  [InventoryEntity_ComputationGroup].[cGroupCode] = [InventoryEntity_Inventory].[cGroupCode]
LEFT JOIN [ComputationUnit] AS [InventoryEntity_ComputationUnit] ON  [InventoryEntity_ComputationUnit].[cComunitCode] = [InventoryEntity_Inventory].[cComUnitCode]
WHERE 1=1  and ([InventoryEntity_Inventory].[cInvCCode] like @treeViewClsCode ) and (bsale=1  and isnull(dEDate,N''9999-12-31'')>N''2017-06-05'') 
) AS A',N'@daesyslogintime nvarchar(4000),@treeviewclscode nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@treeviewclscode=N'CB%',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'

 SELECT cComunitCode, cComUnitName, cGroupCode, ISNULL(iChangRate,0) AS iChangRate , iProportion,  iNumber From ComputationUnit  WHERE cComunitCode =N'0101'



Select cVenAbbName,cInvCode,cInvAddCode,cInvName,cInvStd,cInvCCode,Inventory.cVenCode,inventory.cbarcode,case  inventory.cmassunit when N'1' then N'年' when N'2' then N'月' when N'3' then N'日' else N'' end as cmassunit,case when bAtoModel=1 then N'是' else N'否' end as batomodel,case when bPtoModel=1 then 
N'是' else N'否' end as bptomodel,N'否' as borderbom,N'0' as busecusbom,case isnull(iRequireTrackStyle,0) when 1 then '5' when 2 then '1' when 3 then '4' when 0 then N'' end  as idemandtype,N'' as cdemandcode,N'' as cdemandmemo,case when bInvModel=1 then N'是' else N'否' end as binvmodel,'' as 
icusbomid,'未选配' as cconfigstatus,'0' as natostatus,bService,bAccessary, isnull(iTaxRate,'1.00') as iTaxRate ,iInvWeight,iVolume,bInvBatch, 
cInvDefine1,cInvDefine2,cInvDefine3,cInvDefine4,cInvDefine5,cInvDefine6,cInvDefine7,cInvDefine8,cInvDefine9,cInvDefine10,cInvDefine11,cInvDefine12,cInvDefine13,cInvDefine14,cInvDefine15,cInvDefine16,bserial,bInvType , cGroupCode,cComunitCode, iMassDate, iGroupType, 
cSAComUnitCode,cAssComUnitCode,bInvquality,bTrack,iinvlscost,inventory.cSRPolicy,N'' as cbatchproperty1,N'' as cbatchproperty2,N'' as cbatchproperty3,N'' as cbatchproperty4,N'' as cbatchproperty5,N'' as cbatchproperty6,N'' as cbatchproperty7,N'' as cbatchproperty8,N'' as cbatchproperty9,N'' as 
cbatchproperty10, case when (isnull(bPropertyCheck,0)=1 and iGroupType <>2 )  then N'是' else N'否' end as bgsp ,N'' as dvdate,N'' as dmdate,iExpiratDateCalcu,N'' as dExpirationdate,N'' as cExpirationdate,N'' as cbatch,N''as ibatch,N'' as ccode,N'' as inufts,0 as iSettlePrice,N'' as cvmivenname,N'' as 
cvmivencode,isnull(bbatchcreate,0) as bbatchcreate, isnull(bfree1,0) as bfree1,isnull(bsalepricefree1,0) as bsalepricefree1, isnull(bBatchProperty1,0) as bBatchProperty1, isnull(bfree2,0) as bfree2,isnull(bsalepricefree2,0) as bsalepricefree2, isnull(bBatchProperty2,0) as bBatchProperty2, isnull(bfree3,0) as 
bfree3,isnull(bsalepricefree3,0) as bsalepricefree3, isnull(bBatchProperty3,0) as bBatchProperty3, isnull(bfree4,0) as bfree4,isnull(bsalepricefree4,0) as bsalepricefree4, isnull(bBatchProperty4,0) as bBatchProperty4, isnull(bfree5,0) as bfree5,isnull(bsalepricefree5,0) as bsalepricefree5, 
isnull(bBatchProperty5,0) as bBatchProperty5, isnull(bfree6,0) as bfree6,isnull(bsalepricefree6,0) as bsalepricefree6, isnull(bBatchProperty6,0) as bBatchProperty6, isnull(bfree7,0) as bfree7,isnull(bsalepricefree7,0) as bsalepricefree7, isnull(bBatchProperty7,0) as bBatchProperty7, isnull(bfree8,0) as 
bfree8,isnull(bsalepricefree8,0) as bsalepricefree8, isnull(bBatchProperty8,0) as bBatchProperty8, isnull(bfree9,0) as bfree9,isnull(bsalepricefree9,0) as bsalepricefree9, isnull(bBatchProperty9,0) as bBatchProperty9, isnull(bfree10,0) as bfree10,isnull(bsalepricefree10,0) as bsalepricefree10, 
isnull(bBatchProperty10,0) as bBatchProperty10,iAdvanceDate,case when bService=0 and bInvType=0 then 0 else 0 end as bneedsign, case when bService=0 and bInvType=0 and '普通销售'<>'直运销售' and ''<>'退补'  then warehouse.cwhcode else N'' end as cwhcode,case when bService=0 and bInvType=0  and 
'普通销售'<>'直运销售' and ''<>'退补'  then warehouse.cwhname else N'' end as cwhname,case when bService=0 and bInvType=0  then isnull(warehouse.bproxywh,0) else N'' end as bproxywh  From inventory with (nolock) left join vendor with (nolock) on Inventory.cVenCode=Vendor.cVenCode left join inventory_sub on 
inventory.cinvcode=inventory_sub.cinvsubcode left join warehouse with (nolock) on inventory.cDefWarehouse= warehouse.cwhcode  WHERE (cinvcode=N'C100010008' OR cinvname=N'C100010008' OR    cInvAddCode=N'C100010008' OR Inventory.cBarCode=N'C100010008')  and isnull(dEDate,'9999-12-31')>'2017-06-05' and 
isnull(bSale,0)=1


select isnull(ccusinvcode,N'') as ccusinvcode,isnull(ccusinvname,N'') as ccusinvname,isnull(fCusInvWasteRate,0) as flossrate from CusInvContrapose  where ccuscode=N'00000007' and cinvcode=N'C100010008'

 SELECT cComunitCode, cComUnitName, cGroupCode, ISNULL(iChangRate,0) AS iChangRate , iProportion,  iNumber From ComputationUnit  WHERE cComunitCode =N'0101'



EXEC sp_executesql N'Select cast(0 as bit) as bRefSelectColumn,[SaleOrderQEntity_SaleOrderQ].[id] as id,[SaleOrderQEntity_SaleOrderQ].[csocode] as csocode,[SaleOrderQEntity_SaleOrderQ].[ddate] as ddate,(CASE [SaleOrderQEntity_SaleOrderQ].[cbustype]  WHEN N''直运采购'' THEN N''直运采购'' WHEN N''分期收款'' 
THEN N''分期收款'' WHEN N''直运销售'' THEN N''直运销售'' WHEN N''普通销售'' THEN N''普通销售'' WHEN N''委托'' THEN N''委托'' WHEN N''委托代销'' THEN N''委托代销'' WHEN N''全部业务类型'' THEN N''全部业务类型'' ELSE cast([SaleOrderQEntity_SaleOrderQ].[cbustype] as nvarchar) END) as cbustype,(CASE 
[SaleOrderQEntity_SaleOrderQ].[cbustype]  WHEN N''直运采购'' THEN N''直运采购'' WHEN N''分期收款'' THEN N''分期收款'' WHEN N''直运销售'' THEN N''直运销售'' WHEN N''普通销售'' THEN N''普通销售'' WHEN N''委托'' THEN N''委托'' WHEN N''委托代销'' THEN N''委托代销'' WHEN N''全部业务类型'' THEN N''全部业务类型'' 
ELSE cast([SaleOrderQEntity_SaleOrderQ].[cbustype] as nvarchar) END) as cbustype_Enum_Caption,[SaleOrderQEntity_SaleOrderQ].[cstcode] as cstcode,[SaleOrderQEntity_SaleOrderQ].[cstname] as cstname,[SaleOrderQEntity_SaleOrderQ].[ccuscode] as ccuscode,[SaleOrderQEntity_SaleOrderQ].[ccusname] as 
ccusname,[SaleOrderQEntity_SaleOrderQ].[cexch_name] as cexch_name,[SaleOrderQEntity_SaleOrderQ].[ccusabbname] as ccusabbname,[SaleOrderQEntity_SaleOrderQ].[iexchrate] as iexchrate,[SaleOrderQEntity_SaleOrderSQ].[irowno] as irowno,[SaleOrderQEntity_SaleOrderSQ].[cinvcode] as 
cinvcode,[SaleOrderQEntity_SaleOrderSQ].[cinvname] as cinvname,[SaleOrderQEntity_SaleOrderSQ].[cinvstd] as cinvstd,[SaleOrderQEntity_SaleOrderSQ].[cinvm_unit] as cinvm_unit,[SaleOrderQEntity_SaleOrderSQ].[iquantity] as iquantity,[SaleOrderQEntity_SaleOrderSQ].[dpredate] as 
dpredate,[SaleOrderQEntity_SaleOrderSQ].[dpremodate] as dpremodate,[SaleOrderQEntity_SaleOrderSQ].[iquotedprice] as iquotedprice,[SaleOrderQEntity_SaleOrderSQ].[iinvncost] as iinvncost,[SaleOrderQEntity_SaleOrderSQ].[iinvsprice] as iinvsprice,[SaleOrderQEntity_SaleOrderSQ].[itaxunitprice] as 
itaxunitprice,[SaleOrderQEntity_SaleOrderSQ].[iunitprice] as iunitprice,[SaleOrderQEntity_SaleOrderSQ].[imoney] as iMoney,[SaleOrderQEntity_SaleOrderQ].[itaxrate] as iTaxRate,[SaleOrderQEntity_SaleOrderSQ].[itax] as itax,[SaleOrderQEntity_SaleOrderSQ].[isum] as isum,[SaleOrderQEntity_SaleOrderSQ].[fsalecost] 
as fSaleCost,[SaleOrderQEntity_SaleOrderQ].[cmaker] as cmaker,[SaleOrderQEntity_SaleOrderQ].[cverifier] as cverifier,[SaleOrderQEntity_SaleOrderQ].[cchanger] as cchanger,[SaleOrderQEntity_SaleOrderQ].[clocker] as clocker,[SaleOrderQEntity_SaleOrderSQ].[cscloser] as 
cscloser,[SaleOrderQEntity_SaleOrderSQ].[ifhquantity] as ifhquantity,[SaleOrderQEntity_SaleOrderSQ].[ifhnum] as ifhnum,[SaleOrderQEntity_SaleOrderSQ].[ifhmoney] as ifhmoney,[SaleOrderQEntity_SaleOrderSQ].[ikpquantity] as ikpquantity,[SaleOrderQEntity_SaleOrderSQ].[ikpnum] as 
ikpnum,[SaleOrderQEntity_SaleOrderSQ].[ikpmoney] as ikpmoney,[SaleOrderQEntity_SaleOrderSQ].[imoquantity] as imoquantity,[SaleOrderQEntity_SaleOrderQ].[cmemo] as cMemo,[SaleOrderQEntity_SaleOrderSQ].[isosid] as isosid,[SaleOrderQEntity_SaleOrderQ].[ivtid] as ivtid
FROM [SaleOrderQ] AS [SaleOrderQEntity_SaleOrderQ]
LEFT JOIN [SaleOrderSQ] AS [SaleOrderQEntity_SaleOrderSQ] ON  [SaleOrderQEntity_SaleOrderSQ].[id] = [SaleOrderQEntity_SaleOrderQ].[id] 
WHERE 1=1  and cinvcode=N''C100010008'' and ccuscode=N''00000007'' and cexch_name=N''人民币''',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'


 Select MetaTable.iAuthType as iAuthType ,MetaTable.bAuthControl, MetaTable.cBusObName  from .dbo.aa_busobject_base MetaTable   where MetaTable.cBusObId='orderpriceref' And  MetaTable.langid='zh-CN' order by MetaTable.iAuthType 

select * from dbo.v_aa_enum  where  EnumType in (select distinct EnumType  from UFMETA_559.dbo.AA_Columndic AA_Columndic where AA_Columndic.cKey='orderpriceref' and isEnum=1 )


EXEC sp_executesql N'Select cast(0 as bit) as bRefSelectColumn,[SaleOrderQEntity_SaleOrderQ].[id] as id,[SaleOrderQEntity_SaleOrderQ].[csocode] as csocode,[SaleOrderQEntity_SaleOrderQ].[ddate] as ddate,(CASE [SaleOrderQEntity_SaleOrderQ].[cbustype]  WHEN N''直运采购'' THEN N''直运采购'' WHEN N''分期收款'' 
THEN N''分期收款'' WHEN N''直运销售'' THEN N''直运销售'' WHEN N''普通销售'' THEN N''普通销售'' WHEN N''委托'' THEN N''委托'' WHEN N''委托代销'' THEN N''委托代销'' WHEN N''全部业务类型'' THEN N''全部业务类型'' ELSE cast([SaleOrderQEntity_SaleOrderQ].[cbustype] as nvarchar) END) as cbustype,(CASE 
[SaleOrderQEntity_SaleOrderQ].[cbustype]  WHEN N''直运采购'' THEN N''直运采购'' WHEN N''分期收款'' THEN N''分期收款'' WHEN N''直运销售'' THEN N''直运销售'' WHEN N''普通销售'' THEN N''普通销售'' WHEN N''委托'' THEN N''委托'' WHEN N''委托代销'' THEN N''委托代销'' WHEN N''全部业务类型'' THEN N''全部业务类型'' 
ELSE cast([SaleOrderQEntity_SaleOrderQ].[cbustype] as nvarchar) END) as cbustype_Enum_Caption,[SaleOrderQEntity_SaleOrderQ].[cstcode] as cstcode,[SaleOrderQEntity_SaleOrderQ].[cstname] as cstname,[SaleOrderQEntity_SaleOrderQ].[ccuscode] as ccuscode,[SaleOrderQEntity_SaleOrderQ].[ccusname] as 
ccusname,[SaleOrderQEntity_SaleOrderQ].[cexch_name] as cexch_name,[SaleOrderQEntity_SaleOrderQ].[ccusabbname] as ccusabbname,[SaleOrderQEntity_SaleOrderQ].[iexchrate] as iexchrate,[SaleOrderQEntity_SaleOrderSQ].[irowno] as irowno,[SaleOrderQEntity_SaleOrderSQ].[cinvcode] as 
cinvcode,[SaleOrderQEntity_SaleOrderSQ].[cinvname] as cinvname,[SaleOrderQEntity_SaleOrderSQ].[cinvstd] as cinvstd,[SaleOrderQEntity_SaleOrderSQ].[cinvm_unit] as cinvm_unit,[SaleOrderQEntity_SaleOrderSQ].[iquantity] as iquantity,[SaleOrderQEntity_SaleOrderSQ].[dpredate] as 
dpredate,[SaleOrderQEntity_SaleOrderSQ].[dpremodate] as dpremodate,[SaleOrderQEntity_SaleOrderSQ].[iquotedprice] as iquotedprice,[SaleOrderQEntity_SaleOrderSQ].[iinvncost] as iinvncost,[SaleOrderQEntity_SaleOrderSQ].[iinvsprice] as iinvsprice,[SaleOrderQEntity_SaleOrderSQ].[itaxunitprice] as 
itaxunitprice,[SaleOrderQEntity_SaleOrderSQ].[iunitprice] as iunitprice,[SaleOrderQEntity_SaleOrderSQ].[imoney] as iMoney,[SaleOrderQEntity_SaleOrderQ].[itaxrate] as iTaxRate,[SaleOrderQEntity_SaleOrderSQ].[itax] as itax,[SaleOrderQEntity_SaleOrderSQ].[isum] as isum,[SaleOrderQEntity_SaleOrderSQ].[fsalecost] 
as fSaleCost,[SaleOrderQEntity_SaleOrderQ].[cmaker] as cmaker,[SaleOrderQEntity_SaleOrderQ].[cverifier] as cverifier,[SaleOrderQEntity_SaleOrderQ].[cchanger] as cchanger,[SaleOrderQEntity_SaleOrderQ].[clocker] as clocker,[SaleOrderQEntity_SaleOrderSQ].[cscloser] as 
cscloser,[SaleOrderQEntity_SaleOrderSQ].[ifhquantity] as ifhquantity,[SaleOrderQEntity_SaleOrderSQ].[ifhnum] as ifhnum,[SaleOrderQEntity_SaleOrderSQ].[ifhmoney] as ifhmoney,[SaleOrderQEntity_SaleOrderSQ].[ikpquantity] as ikpquantity,[SaleOrderQEntity_SaleOrderSQ].[ikpnum] as 
ikpnum,[SaleOrderQEntity_SaleOrderSQ].[ikpmoney] as ikpmoney,[SaleOrderQEntity_SaleOrderSQ].[imoquantity] as imoquantity,[SaleOrderQEntity_SaleOrderQ].[cmemo] as cMemo,[SaleOrderQEntity_SaleOrderSQ].[isosid] as isosid,[SaleOrderQEntity_SaleOrderQ].[ivtid] as ivtid
 
FROM [SaleOrderQ] AS [SaleOrderQEntity_SaleOrderQ]
LEFT JOIN [SaleOrderSQ] AS [SaleOrderQEntity_SaleOrderSQ] ON  [SaleOrderQEntity_SaleOrderSQ].[id] = [SaleOrderQEntity_SaleOrderQ].[id]
 
WHERE 1=1  and cinvcode=N''C100010008'' and ccuscode=N''00000007'' and cexch_name=N''人民币''
 
 
 
',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'


select A.cValue, A.cAlias from UserDefine A, UserDef B where B.cClass =N'单据体' and B.cItem =N'自定义项12' and B.cID = A.cID and A.cAlias =N'史蒂夫'

SELECT * FROM SO_SOMain with (nolock) WHERE 1=0


Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829072,95,Null,N'普通销售',Null,N'G',Null,'2017-06-05',N'G201706035600',N'00000007',N'050201',N'07090070',Null,Null,N'003',N'人民币',1,1,Null,N'国内销售收入',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-05','2017-06-05',0,Null,N'南宁市宇盾电子科技有限公司',0,N'王剑',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


SELECT * FROM SO_SODetails with (nolock) WHERE 1=0


 Insert Into 
SO_SODetails(
csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,
inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,
cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,
cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,
fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,
ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,
iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035600',N'C100010008','2017-06-05',2,Null,0,0,0,0,0,0,0,0,0
,0,0,0,Null,Null,Null,Null,Null,Null,Null,Null,Null,189162,100,100,N'H7959-6.0摄像机套装',1
,N'无',N'中文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829072,Null,Null,Null,Null,Null,N'史蒂夫',Null,Null,Null,0,0,Null,Null,Null,'2017-06-05',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,1,N'Systemdefault',N'系统默认分类',Null,Null,Null,0,Null)

use UFDATA_559_2017
select so_sodetails.cinvcode,case when isnull(bconfigfree1,0)=1 then isnull(cfree1,N'') else N'' end as bfree1,case when isnull(bconfigfree2,0)=1 then isnull(cfree2,N'') else N'' end as bfree2,case when isnull(bconfigfree3,0)=1 then isnull(cfree3,N'') else N'' end as bfree3,case when isnull(bconfigfree4,0)=1 
then isnull(cfree4,N'') else N'' end as bfree4,case when isnull(bconfigfree5,0)=1 then isnull(cfree5,N'') else N'' end as bfree5,case when isnull(bconfigfree6,0)=1 then isnull(cfree6,N'') else N'' end as bfree6,case when isnull(bconfigfree7,0)=1 then isnull(cfree7,N'') else N'' end as bfree7,case when 
isnull(bconfigfree8,0)=1 then isnull(cfree8,N'') else N'' end as bfree8,case when isnull(bconfigfree9,0)=1 then isnull(cfree9,N'') else N'' end as bfree9,case when isnull(bconfigfree10,0)=1 then isnull(cfree10,N'') else N'' end as bfree10,case when isnull(bconfigfree1,0)=1 then isnull(cfree1,N'') else N'' 
end as bfree1,case when isnull(bconfigfree2,0)=1 then isnull(cfree2,N'') else N'' end as bfree2,case when isnull(bconfigfree3,0)=1 then isnull(cfree3,N'') else N'' end as bfree3,case when isnull(bconfigfree4,0)=1 then isnull(cfree4,N'') else N'' end as bfree4,case when isnull(bconfigfree5,0)=1 then 
isnull(cfree5,N'') else N'' end as bfree5,case when isnull(bconfigfree6,0)=1 then isnull(cfree6,N'') else N'' end as bfree6,case when isnull(bconfigfree7,0)=1 then isnull(cfree7,N'') else N'' end as bfree7,case when isnull(bconfigfree8,0)=1 then isnull(cfree8,N'') else N'' end as bfree8,case when 
isnull(bconfigfree9,0)=1 then isnull(cfree9,N'') else N'' end as bfree9,case when isnull(bconfigfree10,0)=1 then isnull(cfree10,N'') else N'' end as bfree10 from so_sodetails inner join inventory on so_sodetails.cinvcode=inventory.cinvcode  where idemandtype='5' and id=1829072 group by 
so_sodetails.cinvcode,case when isnull(bconfigfree1,0)=1 then isnull(cfree1,N'') else N'' end ,case when isnull(bconfigfree2,0)=1 then isnull(cfree2,N'') else N'' end ,case when isnull(bconfigfree3,0)=1 then isnull(cfree3,N'') else N'' end ,case when isnull(bconfigfree4,0)=1 then isnull(cfree4,N'') else N'' 
end ,case when isnull(bconfigfree5,0)=1 then isnull(cfree5,N'') else N'' end ,case when isnull(bconfigfree6,0)=1 then isnull(cfree6,N'') else N'' end ,case when isnull(bconfigfree7,0)=1 then isnull(cfree7,N'') else N'' end ,case when isnull(bconfigfree8,0)=1 then isnull(cfree8,N'') else N'' end ,case when 
isnull(bconfigfree9,0)=1 then isnull(cfree9,N'') else N'' end ,case when isnull(bconfigfree10,0)=1 then isnull(cfree10,N'') else N'' end  having count(*)>1

Update customer set bCusState =1 where ccuscode=N'00000007' AND ISNULL(bCusState,0)=0

Select * From VoucherNumber Where CardNumber='17'
Select * from VoucherPrefabricateview Where CardNumber='17'

Select cCode from Vouchercontrapose Where cContent='SaleType' and cSeed='G'




select * From VoucherHistory  with (ROWLOCK)  Where  CardNumber='17' and cContent is NULL

select cNumber as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL
update VoucherHistory set cNumber='35674' Where  CardNumber='17' and cContent is NULL

update so_sodetails set csocode='G201706035600' where id=1829072

update so_sodetails set csocode='1201706035601' where id=1829073

select* from so_sodetails  where id=1829072

Select * from SaleOrderQ where id=1829072

select * from SaleOrderQ where csocode ='G2017060535601'

Select * ,N'' as editprop From SaleOrderSQ where id = 1829072 order by irowno


select cFieldAuthID from Vouchers where cardnumber='17'

Select * from voucherfiexdlabel_lang Where VT_ID='95'  and localeid=dbo.UDF_GetLocaleID() 
select sum(total) as total,max(lastprintTime) as  lastprintTime,GetDate() as CurrentServerDate from PrintPolicy_VCH where  vchid='G201706035600' and PolicyID like '17_%'


Select cSTCode,cSTName from Saletype WHERE (cSTName=N'国内销售★' OR cSTCode=N'国内销售★')
select cNumber as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL
Select cCode from Vouchercontrapose Where cContent='SaleType' and cSeed='01'

EXEC sp_executesql N'SELECT TOP 100  cast(0 as bit) as bRefSelectColumn,[SaleTypeEntity_SaleType].[cSTCode] as cSTCode,[SaleTypeEntity_SaleType].[cSTName] as cSTName,[SaleTypeEntity_SaleType].[cRdCode] as cRdCode,[SaleTypeEntity_SaleType].[bDefault] as 
bDefault,[SaleTypeEntity_SaleType].[bSTMPS_MRP] as bSTMPS_MRP 
 
FROM [SaleType] AS [SaleTypeEntity_SaleType]
 
 
 
 
 Order by cSTCode ASC ',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'


Select cSTCode,cSTName from Saletype WHERE (cSTName=N'国内销售' OR cSTCode=N'国内销售')
select cNumber as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL


select cVer,cCaption,bDefined from ua_caption where cLocaleID='zh-CN'

Select cName,cValue from dbo.AccInformation with (nolock) where cName in('iStrsPriDecDgt','iStrsQuanDecDgt','iVolumeDecDgt','iWeightDecDgt','iBillPrice','iNumDecDgt','iExchRateDecDgt','iRateDecDgt','iKLPoint')
Select idecimaldigits,cid from userdef_base where cid>=201 and cid<=210
 Select MetaTable.iAuthType as iAuthType ,MetaTable.bAuthControl, MetaTable.cBusObName  from .dbo.aa_busobject_base MetaTable   where MetaTable.cBusObId='Inventory' And  MetaTable.langid='zh-CN' order by MetaTable.iAuthType 

select * from dbo.v_aa_enum  where  EnumType in (select distinct EnumType  from UFMETA_559.dbo.AA_Columndic AA_Columndic where AA_Columndic.cKey='Inventory' and isEnum=1 )

EXEC sp_executesql N'Select [InventoryClass_InventoryClass].[cInvCCode],[InventoryClass_InventoryClass].[cInvCName]
 
FROM [InventoryClass] AS [InventoryClass_InventoryClass]
 
 
 
 
 order by cInvCCode ASC ',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'




Select [InventoryClass_InventoryClass].[cInvCCode],[InventoryClass_InventoryClass].[cInvCName]
 
FROM [InventoryClass] AS [InventoryClass_InventoryClass]order by cInvCCode ASC






SELECT cInvCode,cInvName,cInvStd,cInvAddCode,cInvABC,dSDate,cGroupName,cComUnitName FROM Inventory  it LEFT JOIN ComputationGroup cg ON  cg.cGroupCode = it.cGroupCode LEFT JOIN ComputationUnit cu ON cu.cComunitCode = it.cComUnitCode


select * from  UserDef_base  where cClass =N'单据体' and cItem =N'自定义项2' 
select * from dbo.v_aa_enum  where  EnumType in (select distinct EnumType  from UFMETA_559.dbo.AA_Columndic AA_Columndic where AA_Columndic.cKey='UserdefineRef' and isEnum=1 )

EXEC sp_executesql N'SELECT TOP 100  cast(0 as bit) as bRefSelectColumn,[UserdefineEntity_UserDefine].[cAlias] as Calias,[UserdefineEntity_UserDefine].[cValue] as Cvalue 
 
FROM [UserDefine] AS [UserdefineEntity_UserDefine]
 
WHERE 1=1  and ([UserdefineEntity_UserDefine].[cID]=N''23'')
 
 
 
',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'


SELECT TOP 100  cast(0 as bit) as bRefSelectColumn,[UserdefineEntity_UserDefine].[cAlias] as Calias,[UserdefineEntity_UserDefine].[cValue] as Cvalue 
 
FROM [UserDefine] AS [UserdefineEntity_UserDefine]


select Isnull(cAlias,'') as 代码,cValue as 自定义项值 from UserDefine where cID='23'
SELECT Calias,Cvalue from UserDefine where cID='22'


EXEC sp_executesql N'SELECT TOP 100  cast(0 as bit) as bRefSelectColumn,[UserdefineEntity_UserDefine].[cAlias] as Calias,[UserdefineEntity_UserDefine].[cValue] as Cvalue 
 
FROM [UserDefine] AS [UserdefineEntity_UserDefine]
 
 WHERE 1=1   and ([UserdefineEntity_UserDefine].[cID]=N''45'') 
 
 
',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-05 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'


G201706035602


 select IsNULL(Max(iPeriod),0) +1 As iMonth From GL_Mend where bFlag_SA=1

Select bInvType,bService,cInvCode,iGroupType,cGroupCode,isnull(iinvlscost,'') as iinvlscost 
,bfree1,bconfigfree1,bfree2,bconfigfree2,bfree3,bconfigfree3,bfree4,bconfigfree4,bfree5,bconfigfree5,bfree6,bconfigfree6,bfree7,bconfigfree7,bfree8,bconfigfree8,bfree9,bconfigfree9,bfree10,bconfigfree10 from Inventory with (nolock) where cInvCode=N'10000112' 
and bSale<>0 and isnull(dEDate,'9999-12-31')>'2017-06-06'

SELECT csocode FROM SO_SOMain WHERE csocode=N'G201706035602' and id<>0

SELECT * FROM SO_SOMain with (nolock) WHERE 1=0

 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829074,95,Null,N'普通销售',Null,N'G',Null,'2017-06-06',N'G201706035602',N'00000001',N'050208',N'07090070',Null,Null,N'002',N'人民币',1,0,Null,N'销售出库',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-06','2017-06-06',0,Null,N'广州永创电子科技有限公司',0,N'吕中南',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829085,95,Null,N'普通销售',Null,N'G',Null,'2017-06-06',N'G201706035606',N'00000007',N'050201',N'07090070',Null,Null,N'004',N'人民币',1,0,Null,N'原始发票号码：',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-06','2017-06-06',0,Null,N'南宁市宇盾电子科技有限公司',0,N'王剑',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)

set implicit_transactions on 
declare @p5 int
set @p5=1829074
declare @p6 int
set @p6=189164
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6

declare @p1 int
set @p1=6
declare @p7 bit
set @p7=0
exec sp_prepexecrpc @p1 output,N'usp_WF_IsFlowControlled',N'17',N'17.Submit',2017,N'559',@p7 output
select @p1, @p7


 Insert Into 
SO_SODetails(csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid) 
Values 
(N'G201706035602',N'10000112','2017-06-06',2,Null,0,0,0,0,0,0,0,0,0,0,0,0,Null,Null,Null,Null,Null,Null,N'销售出库',Null,Null,189164,100,100,N'贴片陶瓷电容(Z#6)',0,N'P制带客户LOGO',N'俄文',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,1829074,Null,Null,Null,N'客户LOGO',Null,N'无',Null,Null,Null,0,0,Null,Null,Null,'2017-06-06',1,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,0,0,Null,Null,Null,Null,Null,Null,0,Null)



Update customer set bCusState =1 where ccuscode=N'00000001' AND ISNULL(bCusState,0)=0

select * from customer

Select * From VoucherNumber Where CardNumber='17'

Select * from VoucherPrefabricateview Where CardNumber='17'

Select cCode from Vouchercontrapose Where cContent='SaleType' and cSeed='G'

select cNumber as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL
update VoucherHistory set cNumber='35602' Where  CardNumber='17' and cContent is NULL

select * from VoucherHistory where cNumber='35602'

update so_sodetails set csocode='G201706035602' where id=1829074

select * from so_sodetails  where id=1829074


Select * from SaleOrderQ where id=1829074


Select * ,N'' as editprop From SaleOrderSQ where id = 1829074 order by irowno



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


select fchrXmlInfo from dbo.VoucherCustomerInfo where  fchrOperator ='张振初' and fchrVoucherType='17' and fchrType ='VoucherSorterCommand' and fchrVoucherTemplateType='95'



Select VT_TemplateMode as vtmode,isnull(VT_PRN_DEF_LANDID,'') as vtlangid from vouchertemplates_base with (nolock) where vt_id='95'


Select * from voucherfiexdlabel_lang Where VT_ID='95'  and localeid=dbo.UDF_GetLocaleID() 


select * from VoucherAccessories where VoucherTypeID='17' and VoucherID='1829074'


select sum(total) as total,max(lastprintTime) as  lastprintTime,GetDate() as CurrentServerDate from PrintPolicy_VCH where  vchid='G201706035602' and PolicyID like '17_%'


select t1.cexch_name,t1.cexch_code,ISNULL(t2.nflat,1) AS nflat,isnull(idec,0) as idec From (SELECT cexch_name,cexch_code,isnull(idec,0) as idec FROM ForeignCurrency Where cexch_name=N'美元' Or cexch_Code=N'美元') as t1 Left Join (select cexch_name,nflat from 
exch WHERE itype= 2 AND cdate='6') as t2 on t1.cexch_name=t2.cexch_name

select*  FROM ForeignCurrency t1  left join  exch t2 on  t1.cexch_name=t2.cexch_name

select isnull(idec,0) as idec from dbo.foreigncurrency where  cexch_name=N'美元'
select bcal from ForeignCurrency where cexch_name=N'美元'


EXEC sp_executesql N'',N'@daesyslogintime nvarchar(4000),@daesysloginlanguage nvarchar(4000),@daesysloginer nvarchar(4000)',@daesyslogintime=N'2017-06-06 00:00:00',@daesysloginlanguage=N'zh-CN',@daesysloginer=N'17057777'


SELECT cid, ctext, ccode FROM GL_bdigest  Order by cid ASC 

select * from UFSystem..UA_Identity


select* from Somain

set implicit_transactions on 
declare @p5 int
set @p5=1829074
declare @p6 int
set @p6=189164
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6
 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,
imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,
cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,
iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(@p5,95,Null,N'普通销售',Null,N'G',Null,'2017-06-06',N'G201706035610',N'00000011',N'050201',N'07090070',Null,Null,N'002',N'人民币',1,0,Null,N'收发票',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-06','2017-06-06',0,Null,N'中山市三乡镇廖生电脑行（华强电脑）',0,N'廖生',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


declare @p5 int  
 set @p5=1829074  
 declare @p6 int  
 set @p6=189164  
 exec sp_getID '00','559','Somain',1,@p5 output,@p6 output  
 select @p5 as p5, @p6 as p6 
 insert into   
 SO_SOMain(  
 id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,  
 cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,  
 cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,  
 dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,  
 iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode)   
 Values   
 (@p5,'95',Null,'普通销售',Null,'G',Null,getdate(),'G2017060635607','00000001','050201','07090070',Null,Null,'003','人民币',1,0,Null,'备用金',Null,'张振初',  
 Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,getdate(),getdate(),0,Null,'广州永创电子科技有限公司',0,'吕中南',  
 Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)  





use UFDATA_559_2017


select * from [dbo].[SO_SOMain]  order by dDate desc


select * from SO_SOMain where csocode='G201706035690'
select * from SO_SOMain where csocode='G201706035691'
select* from SO_SODetails where csocode='G201706035690'
select* from SO_SODetails where csocode='G201706035691'

IExchRate
iTaxRate


delete from  SO_SOMain   where csocode='H201706035689'                                    
delete from  SO_SODetails   where csocode='H201706035689' 
 
select * from SO_SOMain where csocode='G201706035674'
delete from  SO_SOMain where csocode='G201706035673'

Update customer set bCusState =1 where ccuscode='00000012' AND ISNULL(bCusState,0)=0

1829088

select isnull(cNumber,0) as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL
set implicit_transactions on 
declare @p5 int
set @p5=1829074
declare @p6 int
set @p6=189164
exec sp_getID '00','559','Somain',1,@p5 output,@p6 output
select @p5, @p6

insert into 
SO_SOMain(
id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,
cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,
cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,
dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,
iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(@p5,'95',Null,'普通销售',Null,'{1}',null,getdate(),'{2}','{3}','050201','07090070',null,null,'{4}','{5}',1,0,null,'{6}',null,'{7}',
Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,getdate(),getdate(),0,Null,'{8}',0,'{9}',
Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)


select id from [dbo].[SO_SOMain] where id='1829114'

declare @p5 int  
 set @p5=1829145  
 declare @p6 int  
 set @p6=189164 
 exec sp_getID '00','559','Somain',1,@p5 output,@p6 output  
 select @p5 as p5, @p6 as p6  
 insert into   
 SO_SOMain(  
 id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,  
 cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,  
 cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,  
 dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,  
 iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode)   
 Values   
 ('1829147','95',Null,'普通销售',Null,'G',Null,getdate(),'G201706035673','00000002','050201','07090070',Null,Null,'003','人民币',1,0,Null,'调整开票误差',Null,'张振初',  
 Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,getdate(),getdate(),0,Null,'贺州市富力智能科技有限公司',0,'周振宇',  
 Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)





 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,
imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,
cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,
iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829080,95,Null,N'普通销售',Null,N'W',Null,'2017-06-06',N'W201706035604',N'00000013',N'050201',N'07090070',Null,Null,N'002',N'人民币',1,0,Null,N'销售出库',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-06','2017-06-06',0,Null,N'贵州恒利贸易有限公司',0,N'洪永泽',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)



 Insert Into 
SO_SOMain(id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,cpaycode,cexch_name,iexchrate,itaxrate,
imoney,cmemo,istatus,cmaker,cverifier,ccloser,cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,
cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,
iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode) 
Values 
(1829081,95,Null,N'普通销售',Null,N'Z',Null,'2017-06-06',N'Z201706035605',N'00000002',N'050201',N'07090070',Null,Null,N'005',N'人民币',1,0,Null,N'调整开票误差',Null,N'张振初',Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'2017-06-06','2017-06-06',0,Null,N'贺州市富力智能科技有限公司',0,N'周振宇',Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)




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












