using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Helper
    {
        public string jsonData = "[{Category:'Metal',Type:'Gold',Spread:.01,OpenPrice:1281.1,Price:1280.7317,Buy:1280.7267,Sell:1280.7367,Change:-0.3683,ChangeInPercent:-0.0287,Volume:48387,'High(D)':1289.5,'Low(D)':1279.1,'High(Y)':1306,'Low(Y)':1047.2,'Start(Y)':1176.6,'Change On Year(%)':8.8502,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR: '3.5465',RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Metal',Type:'Silver',Spread:.01,OpenPrice:17.43,Price:17.42,Buy:17.43,Sell:17.43,Change:-0.01,ChangeInPercent:-0.0574,Volume:11720,'High(D)':17.51,'Low(D)':17.37,'High(Y)':18.06,'Low(Y)':13.73,'Start(Y)':15.895,'Change On Year(%)':9.5942,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Metal',Type:'Copper',Spread:.02,OpenPrice:2.123,Price:2.113,Buy:2.123,Sell:2.123,Change:-0.01,ChangeInPercent:-0.471,Volume:28819,'High(D)':2.16,'Low(D)':2.11,'High(Y)':2.94,'Low(Y)':1.96,'Start(Y)':2.45,'Change On Year(%)':-13.7551,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Metal',Type:'Platinum',Spread:.01,OpenPrice:1071.6,Price:1071.0993,Buy:1071.0943,Sell:1071.1043,Change:-0.5007,ChangeInPercent:-0.0467,Volume:3039,'High(D)':1081.2,'Low(D)':1070.5,'High(Y)':1120.6,'Low(Y)':812.4,'Start(Y)':966.5,'Change On Year(%)':10.8225,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Metal',Type:'Palladium',Spread:.01,OpenPrice:600.55,Price:601.0005,Buy:600.9955,Sell:601.0055,Change:.4505,ChangeInPercent:.075,Volume:651,'High(D)':607.2,'Low(D)':598.4,'High(Y)':690,'Low(Y)':458.6,'Start(Y)':574.3,'Change On Year(%)':4.6492,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'Oil',Spread:.015,OpenPrice:45.54,Price:45.7899,Buy:45.7824,Sell:45.7974,Change:.2499,ChangeInPercent:.5487,Volume:107196,'High(D)':45.94,'Low(D)':45,'High(Y)':65.28,'Low(Y)':30.79,'Start(Y)':48.035,'Change On Year(%)':-4.6739,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'Brent',Spread:.01,OpenPrice:46.06,Price:46.05,Buy:46.06,Sell:46.06,Change:-0.01,ChangeInPercent:-0.0217,Volume:59818,'High(D)':46.48,'Low(D)':45.6,'High(Y)':71.14,'Low(Y)':30.02,'Start(Y)':50.58,'Change On Year(%)':-8.9561,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'Natural Gas',Spread:.02,OpenPrice:2.094,Price:2.104,Buy:2.094,Sell:2.094,Change:.01,ChangeInPercent:.4776,Volume:2783,'High(D)':2.11,'Low(D)':2.09,'High(Y)':3.2,'Low(Y)':1.84,'Start(Y)':2.52,'Change On Year(%)':-16.5079,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'RBOB Gas',Spread:.015,OpenPrice:1.5086,Price:1.9532,Buy:1.9457,Sell:1.9607,Change:.4446,ChangeInPercent:29.4686,Volume:2646,'High(D)':1.9532,'Low(D)':1.5,'High(Y)':2.05,'Low(Y)':1.15,'Start(Y)':1.6,'Change On Year(%)':22.0727,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'Diesel',Spread:.015,OpenPrice:1.3474,Price:1.3574,Buy:1.3474,Sell:1.3474,Change:.01,ChangeInPercent:.7422,Volume:2971,'High(D)':1.36,'Low(D)':1.34,'High(Y)':2.11,'Low(Y)':.92,'Start(Y)':1.515,'Change On Year(%)':-10.4026,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'Ethanol',Spread:.01,OpenPrice:1.512,Price:2.7538,Buy:2.7488,Sell:2.7588,Change:1.2418,ChangeInPercent:82.1323,Volume:14,'High(D)':2.7538,'Low(D)':1.1168,'High(Y)':2.7538,'Low(Y)':1.1168,'Start(Y)':1.475,'Change On Year(%)':86.7011,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'Uranium',Spread:.02,OpenPrice:27.55,Price:27.58,Buy:27.55,Sell:27.55,Change:.03,ChangeInPercent:.1089,Volume:12,'High(D)':27.55,'Low(D)':27.55,'High(Y)':29.32,'Low(Y)':21.28,'Start(Y)':25.3,'Change On Year(%)':9.0119,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Oil',Type:'Coal',Spread:.015,OpenPrice:.4363,Price:.4163,Buy:.4363,Sell:.4363,Change:-0.02,ChangeInPercent:-4.584,Volume:3,'High(D)':.4363,'Low(D)':.4363,'High(Y)':.4841,'Low(Y)':.3954,'Start(Y)':.4398,'Change On Year(%)':-5.3326,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Wheat',Spread:.01,OpenPrice:465.5,Price:465.52,Buy:465.5,Sell:465.5,Change:.02,ChangeInPercent:.0043,Volume:4318,'High(D)':467,'Low(D)':463.25,'High(Y)':628.5,'Low(Y)':449.5,'Start(Y)':539,'Change On Year(%)':-13.6327,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Corn',Spread:.01,OpenPrice:379.5,Price:379.8026,Buy:379.7976,Sell:379.8076,Change:.3026,ChangeInPercent:.0797,Volume:11266,'High(D)':381,'Low(D)':377.75,'High(Y)':471.25,'Low(Y)':351.25,'Start(Y)':411.25,'Change On Year(%)':-7.6468,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Sugar',Spread:.01,OpenPrice:15.68,Price:14.6742,Buy:14.6692,Sell:14.6792,Change:-1.0058,ChangeInPercent:-6.4146,Volume:4949,'High(D)':15.7,'Low(D)':14.6742,'High(Y)':16.87,'Low(Y)':11.37,'Start(Y)':14.12,'Change On Year(%)':3.9249,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Soybean',Spread:.01,OpenPrice:1038,Price:1038.6171,Buy:1038.6121,Sell:1038.6221,Change:.6171,ChangeInPercent:.0595,Volume:20356,'High(D)':1044,'Low(D)':1031.75,'High(Y)':1057,'Low(Y)':859.5,'Start(Y)':958.25,'Change On Year(%)':8.3869,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Soy oil',Spread:.01,OpenPrice:33.26,Price:33.7712,Buy:33.7662,Sell:33.7762,Change:.5112,ChangeInPercent:1.5371,Volume:10592,'High(D)':33.7712,'Low(D)':33.06,'High(Y)':35.43,'Low(Y)':26.61,'Start(Y)':31.02,'Change On Year(%)':8.8692,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Soy Meat',Spread:.01,OpenPrice:342.6,Price:342.62,Buy:342.6,Sell:342.6,Change:.02,ChangeInPercent:.0058,Volume:5646,'High(D)':345.4,'Low(D)':340.3,'High(Y)':353.4,'Low(Y)':261.7,'Start(Y)':307.55,'Change On Year(%)':11.403,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'OJ Future',Spread:.01,OpenPrice:140.6,Price:140.1893,Buy:140.1843,Sell:140.1943,Change:-0.4107,ChangeInPercent:-0.2921,Volume:7,'High(D)':140.1893,'Low(D)':0,'High(Y)':155.95,'Low(Y)':113,'Start(Y)':134.475,'Change On Year(%)':4.2493,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Coffee',Spread:.01,OpenPrice:125.7,Price:125.69,Buy:125.7,Sell:125.7,Change:-0.01,ChangeInPercent:-0.008,Volume:1654,'High(D)':125.8,'Low(D)':125,'High(Y)':155.75,'Low(Y)':115.35,'Start(Y)':135.55,'Change On Year(%)':-7.2741,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Cocoa',Spread:.01,OpenPrice:3076,Price:3076.03,Buy:3076,Sell:3076,Change:.03,ChangeInPercent:.001,Volume:978,'High(D)':3078,'Low(D)':3066,'High(Y)':3406,'Low(Y)':2746,'Start(Y)':3076,'Change On Year(%)':.001,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Rice',Spread:.01,OpenPrice:11.245,Price:10.4154,Buy:10.4104,Sell:10.4204,Change:-0.8296,ChangeInPercent:-7.3779,Volume:220,'High(D)':11.38,'Low(D)':10.4154,'High(Y)':14.14,'Low(Y)':9.7,'Start(Y)':11.92,'Change On Year(%)':-12.6228,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Oats',Spread:.01,OpenPrice:194.5,Price:194.2178,Buy:194.2128,Sell:194.2228,Change:-0.2822,ChangeInPercent:-0.1451,Volume:64,'High(D)':195.75,'Low(D)':194,'High(Y)':241.25,'Low(Y)':183.75,'Start(Y)':212.5,'Change On Year(%)':-8.6034,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Milk',Spread:.01,OpenPrice:12.87,Price:12.86,Buy:12.87,Sell:12.87,Change:-0.01,ChangeInPercent:-0.0777,Volume:7,'High(D)':12.89,'Low(D)':12.81,'High(Y)':16.96,'Low(Y)':12.81,'Start(Y)':14.885,'Change On Year(%)':-13.6043,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Cotton',Spread:.01,OpenPrice:61.77,Price:61.76,Buy:61.77,Sell:61.77,Change:-0.01,ChangeInPercent:-0.0162,Volume:3612,'High(D)':62.06,'Low(D)':61.32,'High(Y)':67.59,'Low(Y)':54.33,'Start(Y)':60.96,'Change On Year(%)':1.3123,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Agriculture',Type:'Lumber',Spread:.01,OpenPrice:303.9,Price:304.5994,Buy:304.5944,Sell:304.6044,Change:.6994,ChangeInPercent:.2302,Volume:2,'High(D)':304.5994,'Low(D)':303.9,'High(Y)':317.1,'Low(Y)':236,'Start(Y)':276.55,'Change On Year(%)':10.1426,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Livestock',Type:'LV Cattle',Spread:.01,OpenPrice:120.725,Price:120.705,Buy:120.725,Sell:120.725,Change:-0.02,ChangeInPercent:-0.0166,Volume:4,'High(D)':120.725,'Low(D)':120.725,'High(Y)':147.98,'Low(Y)':113.9,'Start(Y)':130.94,'Change On Year(%)':-7.8166,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Livestock',Type:'FD Cattle',Spread:.01,OpenPrice:147.175,Price:148.6065,Buy:148.6015,Sell:148.6115,Change:1.4315,ChangeInPercent:.9727,Volume:5,'High(D)':148.6065,'Low(D)':147.175,'High(Y)':190,'Low(Y)':138.1,'Start(Y)':164.05,'Change On Year(%)':-9.4139,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Livestock',Type:'Lean Hogs',Spread:.01,OpenPrice:81.275,Price:81.8146,Buy:81.8096,Sell:81.8196,Change:.5396,ChangeInPercent:.664,Volume:1,'High(D)':81.8146,'Low(D)':81.275,'High(Y)':83.98,'Low(Y)':70.25,'Start(Y)':77.115,'Change On Year(%)':6.0943,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Currencies',Type:'USD IDX Future',Spread:.02,OpenPrice:93.88,Price:93.7719,Buy:93.7619,Sell:93.7819,Change:-0.1081,ChangeInPercent:-0.1151,Volume:5788,'High(D)':94.05,'Low(D)':93.7534,'High(Y)':100.7,'Low(Y)':91.88,'Start(Y)':96.29,'Change On Year(%)':-2.6151,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Currencies',Type:'USD/JPY Future',Spread:.02,OpenPrice:9275.5,Price:9277.3342,Buy:9277.3242,Sell:9277.3442,Change:1.8342,ChangeInPercent:.0198,Volume:47734,'High(D)':9277.3342,'Low(D)':.93,'High(Y)':9483,'Low(Y)':.93,'Start(Y)':4741.965,'Change On Year(%)':95.6432,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Currencies',Type:'GBP/USD Future',Spread:.02,OpenPrice:1.4464,Price:1.1941,Buy:1.1841,Sell:1.2041,Change:-0.2523,ChangeInPercent:-17.4441,Volume:29450,'High(D)':1.45,'Low(D)':1.1941,'High(Y)':1.59,'Low(Y)':1.1941,'Start(Y)':1.485,'Change On Year(%)':-19.59,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Currencies',Type:'AUD/USD Future',Spread:.02,OpenPrice:.7344,Price:.7444,Buy:.7344,Sell:.7344,Change:.01,ChangeInPercent:1.3617,Volume:36764,'High(D)':.74,'Low(D)':.73,'High(Y)':.79,'Low(Y)':.68,'Start(Y)':.735,'Change On Year(%)':1.2789,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Currencies',Type:'USD/CAD Future',Spread:.02,OpenPrice:.7744,Price:.9545,Buy:.9445,Sell:.9645,Change:.1801,ChangeInPercent:23.2622,Volume:13669,'High(D)':.9545,'Low(D)':.77,'High(Y)':.9545,'Low(Y)':.68,'Start(Y)':.755,'Change On Year(%)':26.4295,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Currencies',Type:'USD/CHF Future',Spread:.02,OpenPrice:1.0337,Price:1.0437,Buy:1.0337,Sell:1.0337,Change:.01,ChangeInPercent:.9674,Volume:5550,'High(D)':1.03,'Low(D)':1.03,'High(Y)':1.11,'Low(Y)':.98,'Start(Y)':1.045,'Change On Year(%)':-0.1244,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Index',Type:'DOW Future',Spread:.01,OpenPrice:17711,Price:17712.1515,Buy:17712.1465,Sell:17712.1565,Change:1.1515,ChangeInPercent:.0065,Volume:22236,'High(D)':17727,'Low(D)':17642,'High(Y)':18083,'Low(Y)':15299,'Start(Y)':16691,'Change On Year(%)':6.118,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Index',Type:'S&P Future',Spread:.01,OpenPrice:2057.5,Price:2056.6018,Buy:2056.5968,Sell:2056.6068,Change:-0.8982,ChangeInPercent:-0.0437,Volume:142780,'High(D)':2059.5,'Low(D)':2049,'High(Y)':2105.5,'Low(Y)':1794.5,'Start(Y)':1950,'Change On Year(%)':5.4668,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Index',Type:'NAS Future',Spread:.01,OpenPrice:4341.25,Price:4341.28,Buy:4341.25,Sell:4341.25,Change:.03,ChangeInPercent:7e-4,Volume:18259,'High(D)':4347,'Low(D)':4318,'High(Y)':4719.75,'Low(Y)':3867.75,'Start(Y)':4293.75,'Change On Year(%)':1.107,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Index',Type:'S&P MID MINI',Spread:.01,OpenPrice:1454.3,Price:1455.7812,Buy:1455.7762,Sell:1455.7862,Change:1.4812,ChangeInPercent:.1018,Volume:338,'High(D)':1455.7812,'Low(D)':1448,'High(Y)':1527.3,'Low(Y)':1236,'Start(Y)':1381.65,'Change On Year(%)':5.3654,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Index',Type:'S&P 600 MINI',Spread:.01,OpenPrice:687.9,Price:687.88,Buy:687.9,Sell:687.9,Change:-0.02,ChangeInPercent:-0.0029,Volume:0,'High(D)':0,'Low(D)':0,'High(Y)':620.32,'Low(Y)':595.9,'Start(Y)':608.11,'Change On Year(%)':13.1177,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Interest Rate',Type:'US 30YR Future',Spread:.01,OpenPrice:164.875,Price:164.1582,Buy:164.1532,Sell:164.1632,Change:-0.7168,ChangeInPercent:-0.4347,Volume:28012,'High(D)':165.25,'Low(D)':164.0385,'High(Y)':169.38,'Low(Y)':151.47,'Start(Y)':160.425,'Change On Year(%)':2.3271,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Interest Rate',Type:'US 2Y Future',Spread:.01,OpenPrice:109.3984,Price:109.3884,Buy:109.3984,Sell:109.3984,Change:-0.01,ChangeInPercent:-0.0091,Volume:17742,'High(D)':109.41,'Low(D)':109.38,'High(Y)':109.8,'Low(Y)':108.62,'Start(Y)':109.21,'Change On Year(%)':.1634,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Interest Rate',Type:'US 10YR Future',Spread:.01,OpenPrice:130.5625,Price:130.5825,Buy:130.5625,Sell:130.5625,Change:.02,ChangeInPercent:.0153,Volume:189310,'High(D)':130.63,'Low(D)':130.44,'High(Y)':132.64,'Low(Y)':125.48,'Start(Y)':129.06,'Change On Year(%)':1.1797,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null},{Category:'Interest Rate',Type:'Euro$ 3M',Spread:.01,OpenPrice:99.18,Price:99.17,Buy:99.18,Sell:99.18,Change:-0.01,ChangeInPercent:-0.0101,Volume:29509,'High(D)':99.18,'Low(D)':99.17,'High(Y)':99.38,'Low(Y)':98.41,'Start(Y)':98.895,'Change On Year(%)':.2781,IndGrou:'Airlines',IndSect:'Consumer, Cyclical',IndSubg:'Airlines',SecType:'PUBLIC',CpnTyp:'FIXED',IssuerN:'AMERICAN AIRLINES GROUP',Moodys:'WR',Fitch:'N.A.',DBRS:'N.A.',CollatT:'NEW MONEY',Curncy:'USD',Security:'001765866 Pfd',sector:'Pfd',CUSIP:'1765866',Ticker:'AAL',Cpn:'7.875',Maturity:'7/13/1939',KRD_3YR:6e-5,RISK_COUNTRY:'',MUNI_SECTOR:'',ZV_SPREAD:28.302,KRD_5YR:0,KRD_1YR:-0.00187,PD_WALA:null}]";

        public readonly Region[] Regions = new[]
        {
            new Region("North America", new string[] { "Canada", "United States", "Mexico" }),
            new Region("Middle East", new string[] { "Turkey", "Iraq", "Saudi Arabia", "Syria", "UAE", "Israel", "Jordan", "Lebanon", "Oman", "Kuwait", "Qatar", "Bahrain", "Iran" }),
            new Region("Europe", new string[] { "Russia", "Germany", "France", "United Kingdom", "Italy", "Spain", "Poland", "Romania", "Netherlands", "Belgium", "Greece", "Portugal", "Czech Republic", "Hungary", "Sweden", "Austria", "Switzerland", "Bulgaria", "Denmark", "Finland", "Slovakia", "Norway", "Ireland", "Croatia", "Slovenia", "Estonia", "Iceland" }),
            new Region("Africa", new string[] { "Nigeria", "Ethiopia", "Egypt", "South Africa", "Algeria", "Morocco", "Cameroon", "Niger", "Senegal", "Tunisia", "Libya" }),
            new Region("Asia Pacific", new string[] { "Afghanistan", "Australia", "Azerbaijan", "China", "Hong Kong", "India", "Indonesia", "Japan", "Malaysia", "New Zealand", "Pakistan", "Philippines", "Korea", "Singapore", "Taiwan", "Thailand" }),
            new Region("South America", new string[] { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" })
        };

        public static readonly string[] Categories = new[]
        {
            "Metal", "Oil", "Livestock", "Interest Rate", "Index", "Currencies", "Agriculture"
        };

        public static readonly string[] Metals = new[]
        {
            "Gold", "Silver", "Copper", "Platinum", "Palladium"
        };

        public static readonly string[] Oils = new[]
        {
            "Oil", "Brent", "Natural Gas", "RBOB Gas", "Diesel", "Ethanol", "Uranium", "Coal"
        };

        public static readonly string[] Agricultures = new[]
        {
            "Wheat", "Corn", "Sugar", "Soybean", "Soy oil", "Soy Meat", "OJ Future", "Coffee", "Cocoa", "Rice", "Oats", "Milk", "Cotton", "Lumber"
        };

        public static readonly string[] Livestocks = new[]
        {
            "LV Cattle", "FD Cattle", "Lean Hogs"
        };

        public static readonly string[] Currencies = new[]
        {
            "USD IDX Future", "USD/JPY Future", "GBP/USD Future", "AUD/USD Future", "DOW Future", "S&P Future", "NAS Future", "S&P MID MINI"
        };

        public static readonly string[] InterestRates = new[]
        {
            "US 30YR Future", "US 2Y Future", "US 10YR Future", "Euro$ 3M"
        };

        public static readonly string[] Settlements = new[]
        {
            "Deliverable", "Cash"
        };

        public static readonly string[] Contracts = new[]
        {
            "Forwards", "Futures", "Options", "Swap", "CFD"
        };

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// Generates new data based on passed length
        /// </summary>
        /// <param name="data"></param>
        /// <param name="newCount"></param>
        /// <returns></returns>
        public FinancialData[] generatedata(FinancialData[] data, int newCount)
        {
            FinancialData[] newData = new FinancialData[newCount];
            var rng = new Random();
            var getRandomDate = RandomDayFunc();

            for (int i = 0; i < newCount; i++)
            {
                var randomIndex = rng.Next(data.Length);
                // Copy object not by a reference
                newData[i] = copyObjectByValue(data[randomIndex]);
                // creates a number between 0 and 1
                newData[i].Settlement = Settlements[rng.Next(2)];
                newData[i].Contract = Contracts[rng.Next(5)];
                newData[i].LastUpdated = getRandomDate();
                newData[i].OpenPriceDiff = Math.Round((((newData[i].OpenPrice - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].BuyDiff = Math.Round((((newData[i].Buy - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].SellDiff = Math.Round((((newData[i].Sell - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].StartYDiff = Math.Round((((newData[i].StartY - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].HighYDiff = Math.Round((((newData[i].HighY - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].LowYDiff = Math.Round((((newData[i].LowY - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].HighDDiff = Math.Round((((newData[i].HighD - newData[i].Price) / newData[i].Price) * 100) * 15, 4);
                newData[i].LowDDiff = Math.Round((((newData[i].LowD - newData[i].Price) / newData[i].Price) * 100) * 15, 4);

                var tempRegion = Regions[rng.Next(6)];
                newData[i].Region = tempRegion.RegionName;
                newData[i].Country = tempRegion.Countries[rng.Next(tempRegion.Countries.Length)];
                newData[i].ID = i;

                randomizeObjectData(newData[i]);
            }

            return newData;
        }

        /// <summary>
        /// Instead of returning a random date directly, why not return a generator function which can be called repeatedly to create a random date.
        /// You get a factory first: var getRandomDate = RandomDayFunc(); then you call it to get random dates: var randomDate = getRandomDate(); Mind that you need to reuse getRandomDate.
        /// </summary>
        /// <returns></returns>
        Func<DateTime> RandomDayFunc()
        {
            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return () => start.AddDays(gen.Next(range));
        }

        /// <summary>
        /// Updates all Prices fields
        /// </summary>
        /// <param name="finData"></param>
        public void updateRandomPrices(FinancialData[] finData)
        {
            Random rnd = new Random();
            int counter = (int)(0.2 * finData.Length);
            for (int i = 0; i <= counter; i++)
            {
                randomizeObjectData(finData[rnd.Next(finData.Length)]);
            }
        }

        public void updateAllPrices(FinancialData[] finData)
        {
     
            for (int i = 0; i <= finData.Length / 2; i++)
            {
                randomizeObjectData(finData[i]);
                randomizeObjectData(finData[finData.Length - 1 - i]);
            }
        }

        private void randomizeObjectData(FinancialData finDataObj)
        {
            PercentChange pc = generateNewPrice(finDataObj.Price);
            finDataObj.Change = Math.Round((pc.Price - finDataObj.Price), 4);
            finDataObj.Price = Math.Round(pc.Price, 4);
            finDataObj.ChangeP = Math.Round(pc.ChangePercent, 4);
        }

        private PercentChange generateNewPrice(double price)
        {
            Random rnd = new Random();
            int volatility = 2;
            double newPrice;

            double changePercent = 2 * volatility * rnd.NextDouble();
            if (changePercent > volatility) {
                changePercent -= (2 * volatility);
            }

            double changeAmount = price * (changePercent / 100);
            newPrice = price + changeAmount;

            PercentChange result = new PercentChange();
            result.Price = Math.Round(newPrice, 4);
            result.ChangePercent = Math.Round(changePercent, 4) / 100;

            return result;
        }

        /// <summary>
        /// Serializes and Deserializes object in order to copy it by value instead of reference
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private FinancialData copyObjectByValue(FinancialData obj)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            FinancialData newObj = Newtonsoft.Json.JsonConvert.DeserializeObject<FinancialData>(json);

            return newObj;
        }
    }
}
