using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class scanner2
    {
        string[,] arr = new string[71, 50] {{"Empty","a" ,"b" ,"c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","=","!","*","-","+","/","[0-9]","&","|","$"," double "," single ",",","<",">","[","]","{","}",";","~","(",")"},
                                               { "0"   ,"" ,"","27","", "34"  ,"" ,"" ,"","38"  ,"" ,"","66"  ,"" ,"" ,"" ,"" ,"" ,"" ,"76" ,"84" ,"" ,"" ,"92" ,"" ,"" ,"" ," ASS_OP 23","5" ,  "Ari_OP 4" , "Ari_OP 3","Ari_OP 2" , "Ari_OP 19" ,"Constant 1", "12","64" ,"9","7","14" , "comma16","REL_OP 21","relational operator 25" ,"Braces 61","Braces 61","Braces 63","Braces 63" ,"semiclon 101" ,"Logic op 59","Braces 61","Braces 61" },
                                               { "1"   ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","Constant 1" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
                                               { "5","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","relational operators 6","","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"7"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","qoution 8 "  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "9"   ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"close multiple line comment 20" ,"" ,"" ,"" ,"10"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"10"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" , "Single comment 11"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "12"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ," Logic operators 13" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"14"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","Quotation Mark 15","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"17"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","Acess_operator 18"  ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "19"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","open multiple line comment 20  "  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "21"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"relational operator 22 "  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "23"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"", "ASSignment operators 24" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "25"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"relational operator  25" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" , "relational operator  25"    ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "27"  ,"" ,"" ,"" ,"" ,"" ,"" ,"", "28"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "28","29"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","32"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "29"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"30"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"30"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,""  ,"" ,"" ,"" ,"" ,"String 31" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "32"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"", "char 33","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "34"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","35","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"35" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"", "36"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"36"  ,"" ,"" ,"" ,"","Condtition 37 "  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"38"  ,"" ,"" ,"" ,"" ,"","Condtition 39"   ,"" ,"" ,"" ,"" ,"" ,"" ,"","40","46"  ,"" ,"" ,"" ,"","49"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"40"  ,"" ,"" ,"41", ""  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"41"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"42"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"42"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","43"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"43"  ,"" ,"" ,"" ,"44"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"44" ,"" ,"" ,"" ,"" ,"Inclusion 45"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"46"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"Integer 47"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"47"  ,"" ,"" ,"" ,"" ,"" ,"Float 48","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"49"  ,"" ,"" ,"" ,"" ,"50"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "50"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"", "51"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"51" ,"52"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "52"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","53"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "53" ,"" ,"" ,"" ,"" ,"54"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"54"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","55"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "55"  ,"" ,"" ,"" ,"" ,"" ,"" ,"","56" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"56"  ,"" ,"" ,"" ,"","57"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"57"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,""," loop 58" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,""},
{"60"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,""  ,"Braces 61"  ,"" ,"" ,"" ,"","" ,"" },
{ "62"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"", "Braces 63"   ,"" ,"","" ,"" },
{"64"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ," Logic_OP 65"    ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"66"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","67"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"67"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","68"  ,"" ,"" ,"70"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"Integer 79" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"68"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","Struct 69"   ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"70"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"71"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"71"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","72"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"72"  ,"" ,"" ,"" ,"" ,"" ,"" ,"","73"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "73" ,"" ,"" ,"" ,"" ,"74"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"74"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"Loop 75" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"76"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"77" ,"" ,"" ,""  ,"" ,"" ,"" ,"" ,"" ,"" ,"", "81"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"77"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"78"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"78"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"Sinteger 79","" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"79" ,"" ,"" ,"" ,"" ,"","Sfloat 80"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "81"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","82"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"82"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","Break 83"    ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"84" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","85"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "85"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"86"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "86"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"87"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "87"  ,"" ,"88"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"88" ,"89"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "89"  ,"" ,"" ,"90"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"90"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","Return 91"    ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"92"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"93"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "93"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"94"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "94"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"95"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{"95"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"96"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "96"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"97"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "97"  ,"" ,"" ,"" ,"" ,"98"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "98" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"", "99"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" },
{ "99"  ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"", "Void 100"    ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"" ,"","" ,"" }};

        // Category
        public void Scanner(String text)
        { //lowf 3num \n sjdsndj 
            List<String> Lines = text.Split('\n').ToList(); // carry all lines in the code
            bool isStartComment = false;
            int errorCounter = 0;
            foreach (var line in Lines)//to loop on each line in code  1 by 1
            {//Identifier
                //lowf 3num
                List<String> Words = line.Split(' ').ToList(); // carry all Words in the each line
                Words.RemoveAll(r => r == "");
                foreach (var word in Words)//to loop on each Word in line  1 by 1
                {
                    if (word == "$/")
                    {
                        isStartComment = false;
                    }
                    if (isStartComment)
                    {
                        continue;
                    }
                    String token = wordScanner(word, Lines.IndexOf(line));
                    if (token != "word")
                    {
                        Console.WriteLine("Line : " + (Lines.IndexOf(line) + 1) + ", Token Text: " + word + ", Token Type: " + token);
                    }
                    else
                    {
                        if (scanner2.isIdentifier(word) == 1)
                        {
                            Console.WriteLine("Line : " + (Lines.IndexOf(line) + 1) + ", Token Text: " + word + ", Token Type: " + "Identifier");
                        }
                        else
                        {
                            Console.WriteLine("Line : " + (Lines.IndexOf(line) + 1) + ", Token Text: " + word + ", Token Type: " + "Error Not Found");
                            errorCounter++;
                        }
                    }
                    if (word == "$$$")
                    {
                        break;
                    }
                    if (word == "/$")
                    {
                        isStartComment = true;

                    }





                }
                Console.WriteLine("___________________________________________________________");
            }
            Console.WriteLine("\n Total number of erorr is " + errorCounter);
        }
        //if The word is in the language set words
        public string wordScanner(String text, int lineNumber)
        {
            string word = text.ToLower();
            string value = "";
            string token = "";
            int row = 0;
            int i = 0;//number of litter in word //
            if (scanner2.isNumber(text) != 0)
            {
                //Console.WriteLine("Line : " + lineNumber + ", Token Text: " + text + ", Token Type: " + "Constant");
                value = "Constant";
            }
            else
            {
                //loop on columns
                for (int y = 0; y < arr.GetLength(1); y++)
                { //l3 lowf ab
                    //if The first character is in the language set characters
                    if (arr[0, y] == Char.ToString(word[i])) //word[i] + ""
                    {
                        token = arr[1, y];
                    }//else return identifier
                }
                while (true)
                {
                    // if first character is not in the language set characters
                    if (token == "")
                    {
                        //Line : 1 Token Text: Program Token Type: Start Statement
                        //Console.WriteLine("Line : " + lineNumber + ", Token Text: " + text + ", Token Type: " + "Identifier");
                        value = "word";
                        break;
                    }
                    //if token is number
                    if (scanner2.isNumber(token) == 2)
                    {
                        //loop to get down to the row that token refer to
                        for (int r = 0; r < arr.GetLength(0); r++)
                        {
                            if (arr[r, 0] == token)
                            {
                                row = r;
                                //to go to next character
                                i++;
                            }
                        }
                        if (i == word.Length)
                        {
                            value = "word";
                            //Console.WriteLine("Line : " + lineNumber + ", Token Text: " + text + ", Token Type: " + "Identifier");
                            break;
                        }
                        for (int c = 0; c < arr.GetLength(1); c++)
                        {
                            if (arr[0, c] == Char.ToString(word[i]))
                            {
                                token = arr[row, c];
                            }
                        }
                    }
                    else
                    {
                        if (i == (word.Length - 1))
                        {
                            //Console.WriteLine(token);
                            value = token;
                            //Console.WriteLine("Line : " + lineNumber + ", Token Text: " + text + ", Token Type: " + token);
                        }
                        else if (i < (word.Length - 1))
                        {
                            token = token.Split(' ').Last();
                            //Console.WriteLine("token is "+token);
                            continue;
                        }
                        else
                        {
                            //Console.WriteLine("Identifier");
                            value = "word";
                            //Console.WriteLine("Line : " + lineNumber + ", Token Text: " + text + ", Token Type: " + "Identifier");
                        }
                        break;
                    }
                }
            }

            return value;
        }

        static public int isIdentifier(String lex)
        {
            if (lex == "")
            {
                return 0;
            }
            else
            {
                int chAscii0 = (int)lex[0], chAsciiR = 0;
                int firstCharacter = 0;
                int restOfCharacters = 0;
                int isIdentifier = 0;

                if (lex.Length == 1)
                {//if lex is one character
                    if ((chAscii0 >= 65 && chAscii0 <= 90) || (chAscii0 >= 97 && chAscii0 <= 122) || chAscii0 == 95)
                    {
                        firstCharacter = 1;
                        restOfCharacters = 1;
                    }
                }
                else
                {// if lex is multiple characters
                    if ((chAscii0 >= 65 && chAscii0 <= 90) || (chAscii0 >= 97 && chAscii0 <= 122) || chAscii0 == 95)
                    {//checking 1st character
                        firstCharacter = 1;

                    }
                    for (int i = 1; i < lex.Length; i++)
                    {
                        chAsciiR = (int)lex[i];
                        //checking rest of characters
                        if ((chAsciiR >= 65 && chAsciiR <= 90) || (chAsciiR >= 97 && chAsciiR <= 122) || chAsciiR == 95 || (chAsciiR >= 48 && chAsciiR <= 57))
                        {
                            restOfCharacters = 1;

                        }
                        else
                        {
                            restOfCharacters = 0;
                            break;
                        }
                    }

                }


                if (firstCharacter == 1 && restOfCharacters == 1)
                {
                    isIdentifier = 1;
                }
                return isIdentifier;
            }


        }


        static public int isNumber(String s)
        {
            if (s == "") { return 0; }
            else
            {
                int res, i = 0, chAscii, flagFloat = 0, fractCounter = 0;
                char ch;
                while (i < s.Length)
                {
                    ch = s[i];

                    chAscii = (int)ch;
                    if (i != 0)
                    {
                        if ((chAscii >= 48 && chAscii <= 57) || chAscii == 46)
                        {
                            if (chAscii == 46)
                            {
                                //System.out.println(s.charAt(i) + "for i " + i + " is 1");
                                flagFloat = 1;
                                fractCounter++; // Must be one fractional point
                            }
                        }
                        else
                            return 0; // Not Number
                    }
                    else
                    {
                        if (chAscii >= 48 && chAscii <= 57 || chAscii == 46)
                        {
                            if (chAscii == 46)
                            {
                                //System.out.println(s.charAt(i) + "for i " + i + " is 2");
                                flagFloat = 1;
                                fractCounter++; // Must be one fractional point
                            }
                        }
                        else
                            return 0; // Not Number
                    }

                    i++;
                }

                if (flagFloat == 1)
                {
                    if (fractCounter == 1)
                        res = 1; // Float
                    else
                        res = 0; // Not Valid
                }

                else
                    res = 2; // Int

                return res;
            }
        }
    }
}
