
select * from SO_SODetails where csocode='Y201706035706'
select * from SO_SOMain where csocode='Y201706035706'




use ufdata_559_2017



 Update SO_SOMain SET 
id=1829208,ivtid=95,cbustype=N'��ͨ����',cstcode=N'Y',ddate='2017-06-08',csocode=N'Y201706035706',ccuscode=N'00000002',cdepcode=N'03',
cpersoncode=N'07080034',cpaycode=N'004',cexch_name=N'��Ԫ',iexchrate=6.809,itaxrate=2,cmemo=N'���᱾�¹���',cmaker=N'�����',
dpredatebt='2017-06-08T00:00:00',dpremodatebt='2017-06-08T00:00:00',bdisflag=0,ccusname=N'�����и������ܿƼ����޹�˾',breturnflag=0,
ccusperson=N'������',iverifystate=0,iswfcontrolled=0,dcreatesystime='2017-06-08T19:21:17',bcashsale=0,ccrechpname=Null,cmodifier=N'�����',
dmoddate='2017-06-09',dmodifysystime=getdate(),iflowid=Null,cgatheringplan=Null,caddcode=Null,ccusoaddress=Null,csccode=Null 
Where  ID= 1829208 AND convert(char, convert(money,ufts), 2)= N'                   562021.6356'

select* from SaleOrderQ where ID= 1829230

update SO_SOMain set id=id,ivtid=95,cbustype=N'��ͨ����',cstcode=cstcode,ddate=ddate,csocode=csocode,ccuscode=ccuscode,cdepcode=cdepcode,
cpersoncode=cpersoncode,cpaycode=cpaycode,cexch_name=cexch_name,iexchrate=iexchrate,itaxrate=itaxrate,cmemo=cmemo,cmaker=N'�����',
dpredatebt='2017-06-08T00:00:00',dpremodatebt='2017-06-08T00:00:00',bdisflag=0,ccusname=N'�����и������ܿƼ����޹�˾',breturnflag=0,
ccusperson=N'������',iverifystate=0,iswfcontrolled=0,dcreatesystime='2017-06-08T19:21:17',bcashsale=0,ccrechpname=Null,cmodifier=N'�����',
dmoddate='2017-06-09',dmodifysystime=getdate(),iflowid=Null,cgatheringplan=Null,caddcode=Null,ccusoaddress=Null,csccode=Null 
Where  ID= 1829208

select * from SO_SOMain   where ID= 1829230 order by id desc

select * from SO_SODetails where ID= 1829230
 Update SO_SODetails SET 
cinvcode=N'10000102',dpredate='2017-06-13',iquantity=2,inum=Null,iquotedprice=0,iunitprice=2.94,itaxunitprice=3,
imoney=5.88,itax=.12,isum=6,idiscount=0,inatunitprice=20.0185,inatmoney=40.03,inattax=.82,inatsum=40.85,inatdiscount=0,
cmemo=N'���۳���',cfree1=Null,cfree2=Null,isosid=189488,kl=100,kl2=100,cinvname=N'Ƭ״����',itaxrate=2,cdefine22=N'N�ƴ��ͻ�LOGO',
cdefine23=N'�������',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,iinvexchrate=Null,
cunitid=Null,id=1829208,cdefine31=N'�ͻ�LOGO',cdefine33=N'��',fsalecost=0,fsaleprice=0,cscloser=Null,dpremodate='2017-06-13',irowno=1,
icusbomid=Null,ccusinvcode=Null,ccusinvname=Null,dreleasedate='2017-06-08',fcusminprice=0,ballpurchase=0,finquantity=0,foutquantity=0,
fretquantity=0,fretnum=0,borderbom=0,borderbomover=0,idemandtype=Null,cdemandcode=Null,cdemandmemo=Null,busecusbom=0,cSOCode=N'Y201706035706' 
Where  iSOsID= 189488
iarmoney
