use UFDATA_559_2017



if object_id('zhrs_t_zzcSO_SOAddSeriesInfo')is not null
drop table zhrs_t_zzcSO_SOAddSeriesInfo
go
create table zhrs_t_zzcSO_SOAddSeriesInfo
(
SId int identity(1,1)primary key not null,
Csocode varchar(50) not null,  --销售订单号
Cinvcodes varchar(50)not null,  --母件存货编码
Cinvcode  varchar(50)not null,  --子件存货编码
CinvName varchar(225)null,--子件存货名称
Cinvstd  varchar(225)null,--子件规格型号
CcomunitName varchar(10)null,--子件单位
BaseQtyND decimal(28,4)null,--子件使用数量
Ciquantity decimal(28,4)null,--子件使用数量*母件数量
SiQuotedPrice decimal(28,4)null,--含税单价
SiSum decimal(28,4)null,        --含税需金额、
COption1 varchar(225) null,      --选项1标识区分1表示手动录入含税单价，0表示系统平均分配含税单价
COption2 varchar(225) null,      --选项2 拆单员
COption3 varchar(225) null,
COption4 varchar(225) null,
COption5 varchar(225) null,
COption6 varchar(225) null,
COption7 varchar(225) null,
COption8 varchar(225) null,
COption9 varchar(225) null,
COption10 varchar(225) null,
SAddDate datetime not null,     --添加当前时间
isosid int null,                 --母表体单标识
iRow   int null,                 --销售订单行号
SO_SOMain_Id int null,            --母表头单标识
cInvCCode varchar(225) null      --子件存货大类编码
)


select * from zhrs_t_zzcSO_SOAddSeriesInfo where isosid=
delete from zhrs_t_zzcSO_SOAddSeriesInfo


select 
bom_opcomponent.sortseq as 子件行号,bom_opcomponentopt.whcode 创库编码,bom_opcomponent.opseq 工序行号,
Inventory.cInvCode 子件编码,Inventory.cInvCCode 存货大类编码, Inventory.cInvName 子件名称,Inventory.cinvstd 子件规格,Inventory.cInvCCode,
ComputationUnit.ccomunitName 计量单位,
bom_opcomponent.BaseQtyN 基本用量,bom_opcomponent.BaseQtyD 基础数量,(bom_opcomponent.BaseQtyN/bom_opcomponent.BaseQtyD) as 使用数量
from  Inventory (nolock)
left join bas_part (nolock)  on Inventory.cInvCode=bas_part.InvCode 
left join bom_opcomponent (nolock) on bom_opcomponent.componentid=bas_part.partid
left join ComputationUnit (nolock)  on Inventory.cComUnitCode = ComputationUnit.cComUnitCode
left join bom_opcomponentopt (nolock) on bom_opcomponentopt.optionsid=bom_opcomponent.optionsid
where bom_opcomponent.Bomid=310377 order by bom_opcomponent.sortseq
  

select
SELECT cInvCode as 存货编码,cInvName as 存货名称,cInvStd as 规格型号,cInvAddCode as 存货代码,cInvABC as ABC分类,dSDate as 启用日期,cGroupName as 计量单位组名称,cComUnitName as 主计量单位名称  FROM Inventory  it 
LEFT JOIN ComputationGroup cg ON  cg.cGroupCode = it.cGroupCode LEFT JOIN ComputationUnit cu ON cu.cComunitCode = it.cComUnitCode

select * from zhrs_t_CopySaleOrderSQ1
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

create table zhrs_t_CopySaleOrderSQ1
(
autoid varchar(300)null,id varchar(300)null,cinvcode varchar(300)null,bservice varchar(300)null,
cinvname varchar(300)null,cinvaddcode varchar(300)null,body_outid varchar(300)null,cinvstd varchar(300)null,
cunitid varchar(300)null,cinvm_unit varchar(300)null,igrouptype varchar(300)null,cgroupcode varchar(300)null,
cinva_unit varchar(300)null,cinvdefine1 varchar(300)null,cinvdefine2 varchar(300)null,cinvdefine3 varchar(300)null,cinvdefine4 varchar(300)null,
cinvdefine5 varchar(300)null,cinvdefine6 varchar(300)null,cinvdefine7 varchar(300)null,cinvdefine8 varchar(300)null,
cinvdefine9 varchar(300)null,cinvdefine10 varchar(300)null,cinvdefine11 varchar(300)null,cinvdefine12 varchar(300)null,
cinvdefine13 varchar(300)null,cinvdefine14 varchar(300)null,cinvdefine15 varchar(300)null,cinvdefine16 varchar(300)null,
iquantity varchar(300)null,inum varchar(300)null,iquotedprice varchar(300)null,iunitprice varchar(300)null,iinvsprice varchar(300)null,iinvncost varchar(300)null,
imoney varchar(300)null,itax varchar(300)null,isum varchar(300)null,
inatunitprice varchar(300)null,inatmoney varchar(300)null,inattax varchar(300)null,inatsum varchar(300)null,inatdiscount varchar(300)null,idiscount varchar(300)null,
ifhquantity varchar(300)null,ifhnum varchar(300)null,
ifhmoney varchar(300)null,ikpquantity varchar(300)null,fsalecost varchar(300)null,fsaleprice varchar(300)null,iexchsum varchar(300)null,ikpnum varchar(300)null,ikpmoney varchar(300)null,
dpredate varchar(300)null,cmemo varchar(300)null,cfree1 varchar(300)null,
cfree2 varchar(300)null,iinvexchrate varchar(300)null,
iinvlscost varchar(300)null,itaxunitprice varchar(300)null,
bfree1 varchar(300)null,bfree2 varchar(300)null,bfree3 varchar(300)null,bfree4 varchar(300)null,bfree5 varchar(300)null,bfree6 varchar(300)null,
bfree7 varchar(300)null,bfree8 varchar(300)null,bfree9 varchar(300)null,bfree10 varchar(300)null,bsalepricefree1 varchar(300)null,
bsalepricefree2 varchar(300)null,bsalepricefree3 varchar(300)null,bsalepricefree4 varchar(300)null,
bsalepricefree5 varchar(300)null,bsalepricefree6 varchar(300)null,bsalepricefree7 varchar(300)null,
bsalepricefree8 varchar(300)null,bsalepricefree9 varchar(300)null,bsalepricefree10 varchar(300)null,binvtype varchar(300)null,itaxrate varchar(300)null,
kl varchar(300)null,kl2 varchar(300)null,cdefine22 varchar(300)null,cdefine23 varchar(300)null,
cdefine24 varchar(300)null,cdefine25 varchar(300)null,cdefine26 varchar(300)null,cdefine27 varchar(300)null,cdefine28 varchar(300)null,
cdefine29 varchar(300)null,cdefine30 varchar(300)null,cdefine31 varchar(300)null,cdefine32 varchar(300)null,cdefine33 varchar(300)null,
cdefine34 varchar(300)null,cdefine35 varchar(300)null,cdefine36 varchar(300)null,cdefine37 varchar(300)null,isosid varchar(300)null,citemcode varchar(300)null,citem_class varchar(300)null,
dkl1 varchar(300)null,dkl2 varchar(300)null,citemname varchar(300)null,citem_cname varchar(300)null,cfree3 varchar(300)null,
cfree4 varchar(300)null,cfree5 varchar(300)null,cfree6 varchar(300)null,cfree7 varchar(300)null,cfree8 varchar(300)null,
cfree9 varchar(300)null,cfree10 varchar(300)null,cinvauthid varchar(300)null,cscloser varchar(300)null,irowno int null,imoquantity varchar(300)null,
icusbomid varchar(300)null,cconfigstaus varchar(300)null,ccomunitcode varchar(300)null,
ippartseqid varchar(300)null,ippartid varchar(300)null,ippartqty varchar(300)null,dpremodate varchar(300)null,
iquoid varchar(300)null,cquocode varchar(300)null,cbarcode varchar(300)null,
ccontractid varchar(300)null,ccontracttagcode varchar(300)null,
ccontractrowguid varchar(300)null,batomodel varchar(300)null,bptomodel varchar(300)null,ccusinvcode varchar(300)null,
ccusinvname varchar(300)null,fcuminprice varchar(300)null,borderbom varchar(300)null,
borderbomover varchar(300)null,idemandtype varchar(300)null,cdemandcode varchar(300)null,
cdemandmemo varchar(300)null,iprekeepquantity varchar(300)null,iprekeeptotquantity varchar(300)null,iprekeeptotnum varchar(300)null,
busecusbom varchar(300)null,iprekeepnum varchar(300)null,binvmodel varchar(300)null,csrpolicy varchar(300)null,
fpurquan varchar(300)null,iadvancedate varchar(300)null,
dreleasedate varchar(300)null,fimquantity varchar(300)null,
fomquantity varchar(300)null,bproxyforeign varchar(300)null,ballpurchase varchar(300)null,bspercialorder varchar(300)null,
binvbatch varchar(300)null,btrack varchar(300)null,dedate varchar(300)null,
bproductbill varchar(300)null,iaoid varchar(300)null,cpreordercode varchar(300)null,
dbclosedate varchar(300)null,dbclosesystime varchar(300)null,iinvid varchar(300)null,finquantity varchar(300)null,foutquantity varchar(300)null,fretquantity varchar(300)null,
fretnum varchar(300)null,iimid varchar(300)null,ccorvouchtype varchar(300)null,ccorvouchtypename varchar(300)null,icorrowno varchar(300)null,
)

if object_id('zhrs_V_Customer_1') is not null  --客户
drop view zhrs_V_Customer_1
go
create view zhrs_V_Customer_1 as
select * from zhrs_t_Customer_1_0
union all
select * from zhrs_t_Customer_1_1
go
if object_id('zhrs_V_Customerpackage_1') is not null  ---客户+已拆套餐
drop view zhrs_V_Customerpackage_1
go
create view zhrs_V_Customerpackage_1 as
select * from zhrs_t_Customerpackage_1_0
union all
select * from zhrs_t_Customerpackage_1_1
go
if object_id('zhrs_V_Customerpackagetype_1') is not null  ---客户+类型
drop view zhrs_V_Customerpackagetype_1
go
create view zhrs_V_Customerpackagetype_1 as
select * from zhrs_t_Customerpackagetype_1_0
union all
select * from zhrs_t_Customerpackagetype_1_1
go
if object_id('zhrs_V_Customerpackagetypeseries_1') is not null  ---客户+类型+系列
drop view zhrs_V_Customerpackagetypeseries_1
go
create view zhrs_V_Customerpackagetypeseries_1 as
select * from zhrs_t_Customerpackagetypeseries_1_0
union all
select * from zhrs_t_Customerpackagetypeseries_1_1
go
if object_id('zhrs_V_Customerpackagetypeseriesnumber_1') is not null  ---客户+类型+系列+路数
drop view zhrs_V_Customerpackagetypeseriesnumber_1
go
create view zhrs_V_Customerpackagetypeseriesnumber_1 as
select * from zhrs_t_Customerpackagetypeseriesnumber_1_0
union all
select * from zhrs_t_Customerpackagetypeseriesnumber_1_1
go
if object_id('zhrs_V_Package_1') is not null  ---已拆套餐
drop view zhrs_V_Package_1
go
create view zhrs_V_Package_1 as
select * from zhrs_t_Package_1_0
union all
select * from zhrs_t_Package_1_1
go
if object_id('zhrs_V_Combotype_1') is not null  ---已拆套餐+类型
drop view zhrs_V_Combotype_1
go
create view zhrs_V_Combotype_1 as
select * from zhrs_t_Combotype_1_0
union all
select * from zhrs_t_Combotype_1_1
go
if object_id('zhrs_V_CombotypeSeries_1') is not null  ---类型+系列
drop view zhrs_V_CombotypeSeries_1
go
create view zhrs_V_CombotypeSeries_1 as
select * from zhrs_t_CombotypeSeries_1_0
union all
select * from zhrs_t_CombotypeSeries_1_1
go
if object_id('zhrs_V_Packagetypenumberseries_1') is not null  ---类型+系列+路数
drop view zhrs_V_Packagetypenumberseries_1
go
create view zhrs_V_Packagetypenumberseries_1 as
select * from zhrs_t_Packagetypenumberseries_1_0
union all
select * from zhrs_t_Packagetypenumberseries_1_1
go
if object_id('zhrs_V_Salesman_1') is not null  ---业务员
drop view zhrs_V_Salesman_1
go
create view zhrs_V_Salesman_1 as
select * from zhrs_t_Salesman_1_0
union all
select * from zhrs_t_Salesman_1_1
go
if object_id('zhrs_V_RegioncountryCitycustomer_1') is not null  ---地区+国家/城市+客户
drop view zhrs_V_RegioncountryCitycustomer_1
go
create view zhrs_V_RegioncountryCitycustomer_1 as
select * from zhrs_t_RegioncountryCitycustomer_1_0
union all
select * from zhrs_t_RegioncountryCitycustomer_1_1
go
if object_id('zhrs_V_RegioncountryCitycustomerGroupBy_1') is not null  ---分组地区+国家/城市+客户
drop view zhrs_V_RegioncountryCitycustomerGroupBy_1
go
create view zhrs_V_RegioncountryCitycustomerGroupBy_1 as
select * from zhrs_t_RegioncountryCitycustomerGroupBy_1_0
union all
select * from zhrs_t_RegioncountryCitycustomerGroupBy_1_1
go
if object_id('zhrs_V_RegioncountryCity_1') is not null  ---地区+国家/城市
drop view zhrs_V_RegioncountryCity_1
go
create view zhrs_V_RegioncountryCity_1 as
select * from zhrs_t_RegioncountryCity_1_0
union all
select * from zhrs_t_RegioncountryCity_1_1
go
if object_id('zhrs_V_Region_1') is not null  ---地区
drop view zhrs_V_Region_1
go
create view zhrs_V_Region_1 as
select * from zhrs_t_Region_1_0
union all
select * from zhrs_t_Region_1_1
go
if object_id('zhrs_V_Countrytype_1') is not null  ---国家+类型
drop view zhrs_V_Countrytype_1
go
create view zhrs_V_Countrytype_1 as
select * from zhrs_t_Countrytype_1_0
union all
select * from zhrs_t_Countrytype_1_1
go
if object_id('zhrs_V_CountrytypeSeries_1') is not null  ---国家+类型+系列
drop view zhrs_V_CountrytypeSeries_1
go
create view zhrs_V_CountrytypeSeries_1 as
select * from zhrs_t_CountrytypeSeries_1_0
union all
select * from zhrs_t_CountrytypeSeries_1_1
go
if object_id('zhrs_V_Countrytypenumberseries_1') is not null  ---国家+类型+系列+路数
drop view zhrs_V_Countrytypenumberseries_1
go
create view zhrs_V_Countrytypenumberseries_1 as
select * from zhrs_t_Countrytypenumberseries_1_0
union all
select * from zhrs_t_Countrytypenumberseries_1_1
go
if object_id('zhrs_V_Summary_1') is not null  ---汇总
drop view zhrs_V_Summary_1
go
create view zhrs_V_Summary_1 as
select * from zhrs_t_Summary_1_0
union all
select * from zhrs_t_Summary_1_1
go


















