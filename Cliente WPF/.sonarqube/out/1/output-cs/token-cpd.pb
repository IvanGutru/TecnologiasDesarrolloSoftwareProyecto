ÚY
tC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\CallbackMultijugador.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

class  
CallbackMultijugador %
:& '
ServidorJuegoSE( 7
.7 8.
"IAdministradorMultijugadorCallback8 Z
{ 
public		 
Juego		 
Juego		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
public 
Lobby 
Lobby 
{ 
get  
;  !
set" %
;% &
}' (
public 
void 
RecibirMensajeLobby '
(' (
string( .
mensaje/ 6
)6 7
{ 	
Lobby 
. 
Chat 
. 
Add 
( 
mensaje "
)" #
;# $
Lobby 
. 
listBox_Chat 
. 
Items $
.$ %
Refresh% ,
(, -
)- .
;. /
} 	
public 
void &
RecibirMensajeMiembroLobby .
(. /
Boolean/ 6
entrada7 >
,> ?
String@ F
apodoG L
)L M
{ 	
if 
( 
entrada 
) 
{ 
Lobby 
. 
Chat 
. 
Add 
( 
apodo $
+% &
$str' *
++ ,

Properties- 7
.7 8
	Resources8 A
.A B
mensajeEntradaB P
)P Q
;Q R
Lobby 
. 
JugadoresConectados )
.) *
Add* -
(- .
apodo. 3
)3 4
;4 5
Lobby   
.   %
label_JugadoresConectados   /
.  / 0
Content  0 7
=  8 9
Lobby  : ?
.  ? @
JugadoresConectados  @ S
.  S T
Count  T Y
+  Z [

Properties  \ f
.  f g
	Resources  g p
.  p q 
jugadoresConectados	  q Ñ
;
  Ñ Ö
}!! 
else"" 
{## 
Lobby$$ 
.$$ 
Chat$$ 
.$$ 
Add$$ 
($$ 
apodo$$ $
+$$% &
$str$$' *
+$$+ ,

Properties$$- 7
.$$7 8
	Resources$$8 A
.$$A B
mensajeSalida$$B O
)$$O P
;$$P Q
Lobby%% 
.%% 
JugadoresConectados%% )
.%%) *
Remove%%* 0
(%%0 1
apodo%%1 6
)%%6 7
;%%7 8
Lobby&& 
.&& %
label_JugadoresConectados&& /
.&&/ 0
Content&&0 7
=&&8 9
Lobby&&: ?
.&&? @
JugadoresConectados&&@ S
.&&S T
Count&&T Y
+&&Z [

Properties&&\ f
.&&f g
	Resources&&g p
.&&p q 
jugadoresConectados	&&q Ñ
;
&&Ñ Ö
}'' 
Lobby(( 
.(( 
listBox_Chat(( 
.(( 
Items(( $
.(($ %
Refresh((% ,
(((, -
)((- .
;((. /
Lobby)) 
.)) '
listBox_JugadoresConectados)) -
.))- .
Items)). 3
.))3 4
Refresh))4 ;
()); <
)))< =
;))= >
}** 	
public00 
void00 
EntrarJuego00 
(00  
ServidorJuegoSE00  /
.00/ 0
Casilla000 7
[007 8
]008 9
casillas00: B
,00B C
ServidorJuegoSE00D S
.00S T
Portal00T Z
[00Z [
]00[ \
portales00] e
)00e f
{11 	
Lobby22 
.22 
EntrarJuego22 
(22 
casillas22 &
,22& '
portales22( 0
)220 1
;221 2
}33 	
public88 
void88 
RecibirMensaje88 "
(88" #
string88# )
mensaje88* 1
)881 2
{99 	
Juego:: 
.:: 
Chat:: 
.:: 
Add:: 
(:: 
mensaje:: "
)::" #
;::# $
Juego;; 
.;; 
listBox_Chat;; 
.;; 
Items;; $
.;;$ %
Refresh;;% ,
(;;, -
);;- .
;;;. /
}<< 	
publicBB 
voidBB !
RecibirMensajeMiembroBB )
(BB) *
BooleanBB* 1
entradaBB2 9
,BB9 :
StringBB; A
apodoBBB G
)BBG H
{CC 	
ifDD 
(DD 
entradaDD 
)DD 
{EE 
intFF 
indiceApodoFF 
=FF  !
JuegoFF" '
.FF' (
JugadoresConectadosFF( ;
.FF; <
	FindIndexFF< E
(FFE F
xFFF G
=>FFH J
xFFK L
.FFL M
ContainsFFM U
(FFU V
apodoFFV [
)FF[ \
)FF\ ]
;FF] ^
ifGG 
(GG 
indiceApodoGG 
!=GG  "
-GG# $
$numGG$ %
)GG% &
{HH 
returnII 
;II 
}JJ 
JuegoKK 
.KK 
ChatKK 
.KK 
AddKK 
(KK 
apodoKK $
+KK% &
$strKK' *
+KK+ ,

PropertiesKK- 7
.KK7 8
	ResourcesKK8 A
.KKA B
mensajeEntradaKKB P
)KKP Q
;KKQ R
JuegoLL 
.LL 
JugadoresConectadosLL )
.LL) *
AddLL* -
(LL- .
apodoLL. 3
)LL3 4
;LL4 5
}MM 
elseNN 
{OO 
JuegoPP 
.PP 
ChatPP 
.PP 
AddPP 
(PP 
apodoPP $
+PP% &
$strPP' *
+PP+ ,

PropertiesPP- 7
.PP7 8
	ResourcesPP8 A
.PPA B
mensajeSalidaPPB O
)PPO P
;PPP Q
JuegoQQ 
.QQ 
JugadoresConectadosQQ )
.QQ) *
RemoveQQ* 0
(QQ0 1
apodoQQ1 6
)QQ6 7
;QQ7 8
}RR 
JuegoSS 
.SS 
listBox_ChatSS 
.SS 
ItemsSS $
.SS$ %
RefreshSS% ,
(SS, -
)SS- .
;SS. /
JuegoTT 
.TT '
listBox_JugadoresConectadosTT -
.TT- .
ItemsTT. 3
.TT3 4
RefreshTT4 ;
(TT; <
)TT< =
;TT= >
}UU 	
public]] 
void]] 
ElegirFicha]] 
(]]  
String]]  &
apodo]]' ,
,]], -
ServidorJuegoSE]]. =
.]]= >
Ficha]]> C
[]]C D
]]]D E
fichasEscogidas]]F U
)]]U V
{^^ 	
Turno__ 
turno__ 
=__ 
new__ 
Turno__ #
(__# $
Juego__$ )
)__) *
;__* +
Juego`` 
.`` 
label_Aviso`` 
.`` 
Content`` %
=``& '
apodo``( -
+``. /
$str``0 M
;``M N
ifaa 
(aa 
apodoaa 
.aa 
Equalsaa 
(aa 
Juegoaa "
.aa" #
Jugadoraa# *
.aa* +
Apodoaa+ 0
)aa0 1
)aa1 2
{bb 
turnocc 
.cc 
ElegirFichacc !
(cc! "
fichasEscogidascc" 1
.cc1 2
ToListcc2 8
(cc8 9
)cc9 :
)cc: ;
;cc; <
turnodd 
.dd 

ShowDialogdd  
(dd  !
)dd! "
;dd" #
}ee 
}ff 	
publicjj 
voidjj !
SolicitarCrearTablerojj )
(jj) *
)jj* +
{kk 	
throwll 
newll #
NotImplementedExceptionll -
(ll- .
)ll. /
;ll/ 0
}mm 	
publicrr 
voidrr 
MostrarFichaElegidarr '
(rr' (
ServidorJuegoSErr( 7
.rr7 8
Ficharr8 =
ficharr> C
)rrC D
{ss 	
Juegott 
.tt 
JugadorEnTurnott  
=tt! "
fichatt# (
;tt( )
Juegouu 
.uu !
MostrarFichaEnTablerouu '
(uu' (
)uu( )
;uu) *
}vv 	
public{{ 
void{{ 
Tirar{{ 
({{ 
String{{  
apodo{{! &
){{& '
{|| 	
Turno}} 
turno}} 
=}} 
new}} 
Turno}} #
(}}# $
Juego}}$ )
)}}) *
;}}* +
Juego~~ 
.~~ 
label_Aviso~~ 
.~~ 
Content~~ %
=~~& '
apodo~~( -
+~~. /
$str~~0 B
;~~B C
if 
( 
apodo 
. 
Equals 
( 
Juego "
." #
Jugador# *
.* +
Apodo+ 0
)0 1
)1 2
{
ÄÄ 
turno
ÅÅ 
.
ÅÅ 
Tirar
ÅÅ 
(
ÅÅ 
)
ÅÅ 
;
ÅÅ 
turno
ÇÇ 
.
ÇÇ 

ShowDialog
ÇÇ  
(
ÇÇ  !
)
ÇÇ! "
;
ÇÇ" #
}
ÉÉ 
}
ÑÑ 	
public
ââ 
void
ââ 
MostrarTiro
ââ 
(
ââ  
ServidorJuegoSE
ââ  /
.
ââ/ 0
Ficha
ââ0 5
ficha
ââ6 ;
)
ââ; <
{
ää 	
Juego
ãã 
.
ãã 
JugadorEnTurno
ãã  
=
ãã! "
ficha
ãã# (
;
ãã( )
Juego
åå 
.
åå 

MoverFicha
åå 
(
åå 
false
åå "
)
åå" #
;
åå# $
}
çç 	
public
îî 
void
îî #
MostrarNuevosPortales
îî )
(
îî) *
ServidorJuegoSE
îî* 9
.
îî9 :
Portal
îî: @
[
îî@ A
]
îîA B
portales
îîC K
)
îîK L
{
ïï 	
Juego
ññ 
.
ññ 
CambiarPortales
ññ !
(
ññ! "
portales
ññ" *
)
ññ* +
;
ññ+ ,
}
óó 	
public
úú 
void
úú 
MostrarGanador
úú "
(
úú" #
ServidorJuegoSE
úú# 2
.
úú2 3
Ficha
úú3 8
ficha
úú9 >
)
úú> ?
{
ùù 	
Turno
ûû 
turno
ûû 
=
ûû 
new
ûû 
Turno
ûû #
(
ûû# $
Juego
ûû$ )
)
ûû) *
;
ûû* +
Juego
üü 
.
üü 
label_Aviso
üü 
.
üü 
Content
üü %
=
üü& '
$str
üü( *
;
üü* +
turno
†† 
.
†† 
MostrarGanador
††  
(
††  !
ficha
††! &
)
††& '
;
††' (
turno
°° 
.
°° 

ShowDialog
°° 
(
°° 
)
°° 
;
°° 
Juego
¢¢ 
.
¢¢ 
Close
¢¢ 
(
¢¢ 
)
¢¢ 
;
¢¢ 
}
££ 	
}
¶¶ 
}ßß ¡
vC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\ConsultarPuntajes.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public		 

partial		 
class		 
ConsultarPuntajes		 *
:		+ ,
Window		- 3
{		4 5
private 
ServidorJuegoSE 
.  
Jugador  '
jugador( /
;/ 0
public 
ConsultarPuntajes  
(  !
ServidorJuegoSE! 0
.0 1
Jugador1 8
jugadorRecibido9 H
)H I
{J K
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
ServidorJuegoSE 
. %
AdministradorCuentaClient 5
cliente6 =
=> ?
new@ C
ServidorJuegoSED S
.S T%
AdministradorCuentaClientT m
(m n
)n o
;o p 
DataGrid_MisPuntajes  
.  !
ItemsSource! ,
=- .
cliente/ 6
.6 7$
ConsultarPuntajesPropios7 O
(O P
jugadorP W
)W X
;X Y$
DataGrid_MejoresPuntajes $
.$ %
ItemsSource% 0
=1 2
cliente3 :
.: ;$
ConsultarMejoresPuntajes; S
(S T
)T U
;U V
} 	
private 
void 
Button_Click !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{D E
MenuPrincipal 
ventanaPrincipal *
=+ ,
new- 0
MenuPrincipal1 >
(> ?
jugador? F
)F G
;G H
ventanaPrincipal 
. 
Show !
(! "
)" #
;# $
this 
. 
Close 
( 
) 
; 
} 	
private 
void 2
&DataGrid_Puntajes_AutoGeneratingColumn ;
(; <
object< B
senderC I
,I J1
%DataGridAutoGeneratingColumnEventArgsK p
eq r
)r s
{   	
string!! 
titulo!! 
=!! 
e!! 
.!! 
Column!! $
.!!$ %
Header!!% +
.!!+ ,
ToString!!, 4
(!!4 5
)!!5 6
;!!6 7
if"" 
("" 
titulo"" 
=="" 
$str"" )
)"") *
{## 
e$$ 
.$$ 
Cancel$$ 
=$$ 
true$$ 
;$$  
}%% 
}&& 	
}'' 
}(( ∏I
sC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\IngresarCodigo.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
IngresarCodigo '
:( )
Window* 0
{1 2
private 
readonly 
ServidorJuegoSE (
.( )
Cuenta) /
cuenta0 6
;6 7
public 
IngresarCodigo 
( 
ServidorJuegoSE .
.. /
Cuenta/ 5
cuentaRecibida6 D
)D E
{F G
cuenta 
= 
cuentaRecibida #
;# $
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Salir !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{D E

MainWindow 
vetanaPrincipal &
=' (
new) ,

MainWindow- 7
(7 8
)8 9
;9 :
vetanaPrincipal 
. 
Show  
(  !
)! "
;" #
this 
. 
Close 
( 
) 
; 
} 	
private 
void  
Button_ValidarCuenta )
() *
object* 0
sender1 7
,7 8
RoutedEventArgs9 H
eI J
)J K
{L M
if 
( 
textBox_Codigo 
. 
Text #
==$ &
$str' )
)) *
{+ ,
string 
ingresarCodigo %
=& '

Properties( 2
.2 3
	Resources3 <
.< =$
ingresarCodigoActivacion= U
;U V

MessageBox   
.   
Show   
(    
ingresarCodigo    .
)  . /
;  / 0
return!! 
;!! 
}"" 
ServidorJuegoSE## 
.## %
AdministradorCuentaClient## 5
cliente##6 =
=##> ?
new##@ C
ServidorJuegoSE##D S
.##S T%
AdministradorCuentaClient##T m
(##m n
)##n o
;##o p
try$$ 
{%% 
int&& 
	respuesta&& 
=&& 
cliente&&  '
.&&' ( 
ActivarCuentaJugador&&( <
(&&< =
cuenta&&= C
,&&C D
textBox_Codigo&&E S
.&&S T
Text&&T X
)&&X Y
;&&Y Z
if'' 
('' 
	respuesta'' 
==''  
(''! "
int''" %
)''% &
EstadoDeOperacion''& 7
.''7 8
OperacionExitosa''8 H
)''H I
{(( 
var)) 
cuentaActivada)) &
=))' (

Properties))) 3
.))3 4
	Resources))4 =
.))= >
cuentaActivada))> L
;))L M

MessageBox** 
.** 
Show** #
(**# $
cuentaActivada**$ 2
)**2 3
;**3 4

MainWindow++ 
vetanaPrincipal++ .
=++/ 0
new++1 4

MainWindow++5 ?
(++? @
)++@ A
;++A B
vetanaPrincipal,, #
.,,# $
Show,,$ (
(,,( )
),,) *
;,,* +
this-- 
.-- 
Close-- 
(-- 
)--  
;--  !
}.. 
else// 
if// 
(// 
	respuesta// "
==//# %
(//& '
int//' *
)//* +
EstadoDeOperacion//+ <
.//< =
CodigoInvalido//= K
)//K L
{00 

MessageBox11 
.11 
Show11 #
(11# $

Properties11$ .
.11. /
	Resources11/ 8
.118 9
codigoInvalido119 G
)11G H
;11H I
}22 
else33 
if33 
(33 
	respuesta33 "
==33# %
(33& '
int33' *
)33* +
EstadoDeOperacion33+ <
.33< =
ErrorBaseDatos33= K
||33L N
	respuesta33O X
==33Y [
(33\ ]
int33] `
)33` a
EstadoDeOperacion33a r
.33r s
	Excepcion33s |
)33| }
{44 

MessageBox55 
.55 
Show55 #
(55# $

Properties55$ .
.55. /
	Resources55/ 8
.558 9"
errorConexionBaseDatos559 O
,55O P

Properties55Q [
.55[ \
	Resources55\ e
.55e f
tituloErrorConexion55f y
,55y z
MessageBoxButton	55{ ã
.
55ã å
OK
55å é
,
55é è
MessageBoxImage
55ê ü
.
55ü †
Error
55† •
)
55• ¶
;
55¶ ß
}66 
}77 
catch88 
(88 
System88 
.88 
ServiceModel88 &
.88& '%
EndpointNotFoundException88' @
)88@ A
{99 

MessageBox:: 
.:: 
Show:: 
(::  

Properties::  *
.::* +
	Resources::+ 4
.::4 5!
errorConexionServidor::5 J
,::J K

Properties::L V
.::V W
	Resources::W `
.::` a
tituloErrorConexion::a t
,::t u
MessageBoxButton	::v Ü
.
::Ü á
OK
::á â
,
::â ä
MessageBoxImage
::ã ö
.
::ö õ
Error
::õ †
)
::† °
;
::° ¢
};; 
}<< 	
private>> 
void>> !
Button_ReenviarCorreo>> *
(>>* +
object>>+ 1
sender>>2 8
,>>8 9
RoutedEventArgs>>: I
e>>J K
)>>K L
{>>M N
ServidorJuegoSE?? 
.?? %
AdministradorCuentaClient?? 5
cliente??6 =
=??> ?
new??@ C
ServidorJuegoSE??D S
.??S T%
AdministradorCuentaClient??T m
(??m n
)??n o
;??o p
int@@ 
	respuesta@@ 
;@@ 
tryAA 
{AA 
	respuestaBB 
=BB 
clienteBB #
.BB# $
EnviarCorreoBB$ 0
(BB0 1
cuentaBB1 7
)BB7 8
;BB8 9
ifCC 
(CC 
	respuestaCC 
==CC  
(CC! "
intCC" %
)CC% &
EstadoDeOperacionCC& 7
.CC7 8
OperacionExitosaCC8 H
)CCH I
{CCJ K

MessageBoxDD 
.DD 
ShowDD #
(DD# $

PropertiesDD$ .
.DD. /
	ResourcesDD/ 8
.DD8 9
correoEnviadoDD9 F
)DDF G
;DDG H
}EE 
ifFF 
(FF 
	respuestaFF 
==FF  
(FF! "
intFF" %
)FF% &
EstadoDeOperacionFF& 7
.FF7 8
ErrorBaseDatosFF8 F
)FFF G
{GG 

MessageBoxHH 
.HH 
ShowHH #
(HH# $

PropertiesHH$ .
.HH. /
	ResourcesHH/ 8
.HH8 9"
errorConexionBaseDatosHH9 O
,HHO P

PropertiesHHQ [
.HH[ \
	ResourcesHH\ e
.HHe f
tituloErrorConexionHHf y
,HHy z
MessageBoxButton	HH{ ã
.
HHã å
OK
HHå é
,
HHé è
MessageBoxImage
HHê ü
.
HHü †
Error
HH† •
)
HH• ¶
;
HH¶ ß
}II 
ifJJ 
(JJ 
	respuestaJJ 
==JJ  
(JJ! "
intJJ" %
)JJ% &
EstadoDeOperacionJJ& 7
.JJ7 8
NoSeEnvioCorreoJJ8 G
)JJG H
{KK 

MessageBoxLL 
.LL 
ShowLL #
(LL# $

PropertiesLL$ .
.LL. /
	ResourcesLL/ 8
.LL8 9
errorMandarCorreoLL9 J
)LLJ K
;LLK L
}MM 
}NN 
catchOO 
(OO 
SystemOO 
.OO 
ServiceModelOO &
.OO& '%
EndpointNotFoundExceptionOO' @
)OO@ A
{PP 

MessageBoxQQ 
.QQ 
ShowQQ 
(QQ  

PropertiesQQ  *
.QQ* +
	ResourcesQQ+ 4
.QQ4 5!
errorConexionServidorQQ5 J
,QQJ K

PropertiesQQL V
.QQV W
	ResourcesQQW `
.QQ` a
tituloErrorConexionQQa t
,QQt u
MessageBoxButton	QQv Ü
.
QQÜ á
OK
QQá â
,
QQâ ä
MessageBoxImage
QQã ö
.
QQö õ
Error
QQõ †
)
QQ† °
;
QQ° ¢
}RR 
}TT 	
enumUU 
EstadoDeOperacionUU 
{UU 
OperacionExitosaVV 
=VV 
$numVV  
,VV  !
ErrorBaseDatosWW 
=WW 
-WW 
$numWW  
,WW  !
NoSeEnvioCorreoXX 
=XX 
-XX 
$numXX  
,XX  !
CodigoInvalidoYY 
=YY 
-YY 
$numYY 
,YY  
	ExcepcionZZ 
=ZZ 
-ZZ 
$numZZ 
,ZZ 
}[[ 	
}]] 
}^^ ÌÕ
jC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Juego.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
Juego 
:  
Window! '
{ 
InstanceContext 
contexto  
;  !
private  
CallbackMultijugador $
regresoJuego% 1
;1 2
private 
MediaPlayer 
musicaFondo '
=( )
new* -
MediaPlayer. 9
(9 :
): ;
;; <
public 
Juego 
( 
ServidorJuegoSE $
.$ %
Jugador% ,
jugadorRecibido- <
,< =
ServidorJuegoSE> M
.M N
SalaN R
salaRecibidaS _
,_ ` 
CallbackMultijugadora u
regresoMensaje	v Ñ
)
Ñ Ö
{ 	
Jugador   
=   
jugadorRecibido   %
;  % &
Sala!! 
=!! 
salaRecibida!! 
;!!  
regresoJuego"" 
="" 
regresoMensaje"" )
;"") *
InitializeComponent## 
(##  
)##  !
;##! "
listBox_Chat$$ 
.$$ 
ItemsSource$$ $
=$$% &
Chat$$' +
;$$+ ,'
listBox_JugadoresConectados%% '
.%%' (
ItemsSource%%( 3
=%%4 5
JugadoresConectados%%6 I
;%%I J
regresoJuego&& 
.&& 
Juego&& 
=&&  
this&&! %
;&&% &
contexto'' 
='' 
new'' 
InstanceContext'' *
(''* +
regresoJuego''+ 7
)''7 8
;''8 9
ClienteMultijugador(( 
=((  !
new((" %
ServidorJuegoSE((& 5
.((5 6+
AdministradorMultijugadorClient((6 U
(((U V
contexto((V ^
)((^ _
;((_ `

ImageBrush)) 
	brushGrid))  
=))! "
new))# &

ImageBrush))' 1
())1 2
)))2 3
;))3 4
	brushGrid** 
.** 
ImageSource** !
=**" #
new**$ '
BitmapImage**( 3
(**3 4
new**4 7
Uri**8 ;
(**; <
Sala**< @
.**@ A
UriFondoTablero**A P
)**P Q
)**Q R
;**R S
grid_Tablero++ 
.++ 

Background++ #
=++$ %
	brushGrid++& /
;++/ 0
musicaFondo,, 
.,, 
MediaOpened,, #
+=,,$ &
SoundTrackCargado,,' 8
;,,8 9
musicaFondo-- 
.-- 

MediaEnded-- "
+=--# % 
SoundTrackFinalizado--& :
;--: ;
musicaFondo.. 
... 
Open.. 
(.. 
new..  
Uri..! $
(..$ %
$str..% U
)..U V
)..V W
;..W X
}// 	
public11 
List11 
<11 
ServidorJuegoSE11 #
.11# $
Casilla11$ +
>11+ ,
Casillas11- 5
{116 7
get118 ;
;11; <
set11= @
;11@ A
}11B C
public22 
List22 
<22 
ServidorJuegoSE22 #
.22# $
Portal22$ *
>22* +
Portales22, 4
{225 6
get227 :
;22: ;
set22< ?
;22? @
}22A B
public33 
Jugador33 
Jugador33 
{33  
get33! $
;33$ %
set33& )
;33) *
}33+ ,
public44 
List44 
<44 
string44 
>44 
Chat44  
{44! "
get44# &
;44& '
set44( +
;44+ ,
}44- .
=44/ 0
new441 4
List445 9
<449 :
string44: @
>44@ A
(44A B
)44B C
;44C D
public55 +
AdministradorMultijugadorClient55 .
ClienteMultijugador55/ B
{55C D
get55E H
;55H I
set55J M
;55M N
}55O P
public66 
Sala66 
Sala66 
{66 
get66 
;66 
set66  #
;66# $
}66% &
public77 
Ficha77 
JugadorEnTurno77 #
{77$ %
get77& )
;77) *
set77+ .
;77. /
}770 1
=772 3
new774 7
ServidorJuegoSE778 G
.77G H
Ficha77H M
(77M N
)77N O
;77O P
public88 
List88 
<88 
string88 
>88 
JugadoresConectados88 /
{880 1
get882 5
;885 6
set887 :
;88: ;
}88< =
=88> ?
new88@ C
List88D H
<88H I
String88I O
>88O P
(88P Q
)88Q R
;88R S
public== 
void== 
InicializarTablero== &
(==& '
)==' (
{>> 	%
ColocarCasillasEspeciales?? %
(??% &
)??& '
;??' (
ColocarPortales@@ 
(@@ 
)@@ 
;@@ 
}AA 	
privateCC 
voidCC 
SoundTrackCargadoCC &
(CC& '
objectCC' -
senderCC. 4
,CC4 5
	EventArgsCC6 ?
eCC@ A
)CCA B
{DD 	
musicaFondoEE 
.EE 
PlayEE 
(EE 
)EE 
;EE 
}FF 	
privateHH 
voidHH  
SoundTrackFinalizadoHH )
(HH) *
objectHH* 0
senderHH1 7
,HH7 8
	EventArgsHH9 B
eHHC D
)HHD E
{II 	
musicaFondoJJ 
.JJ 
PlayJJ 
(JJ 
)JJ 
;JJ 
}KK 	
privateOO 
voidOO %
ColocarCasillasEspecialesOO .
(OO. /
)OO/ 0
{PP 	
ImageQQ 
casillaEspecialQQ !
;QQ! "
varRR 
casillasEspecialesRR "
=RR# $
CasillasRR% -
.RR- .
WhereRR. 3
(RR3 4
xRR4 5
=>RR6 8
xRR9 :
.RR: ;
EspecialRR; C
)RRC D
.RRD E
ToListRRE K
(RRK L
)RRL M
;RRM N
forSS 
(SS 
intSS 
iSS 
=SS 
$numSS 
;SS 
iSS 
<SS 
casillasEspecialesSS  2
.SS2 3
CountSS3 8
;SS8 9
iSS: ;
++SS; =
)SS= >
{TT 
casillaEspecialUU 
=UU  !
newUU" %
ImageUU& +
(UU+ ,
)UU, -
;UU- .
casillaEspecialVV 
.VV  
SourceVV  &
=VV' (
newVV) ,
BitmapImageVV- 8
(VV8 9
newVV9 <
UriVV= @
(VV@ A
$strVVA h
,VVh i
UriKindVVj q
.VVq r
RelativeVVr z
)VVz {
)VV{ |
;VV| }
casillaEspecialWW 
.WW  
HorizontalAlignmentWW  3
=WW4 5
HorizontalAlignmentWW6 I
.WWI J
LeftWWJ N
;WWN O
casillaEspecialXX 
.XX  
VerticalAlignmentXX  1
=XX2 3
VerticalAlignmentXX4 E
.XXE F
BottomXXF L
;XXL M
casillaEspecialYY 
.YY  
HeightYY  &
=YY' (
$numYY) +
;YY+ ,
GridZZ 
.ZZ 
	SetColumnZZ 
(ZZ 
casillaEspecialZZ .
,ZZ. /
casillasEspecialesZZ0 B
[ZZB C
iZZC D
]ZZD E
.ZZE F
ColumnaZZF M
)ZZM N
;ZZN O
Grid[[ 
.[[ 
SetRow[[ 
([[ 
casillaEspecial[[ +
,[[+ ,
casillasEspeciales[[- ?
[[[? @
i[[@ A
][[A B
.[[B C
Fila[[C G
)[[G H
;[[H I
grid_Tablero\\ 
.\\ 
Children\\ %
.\\% &
Add\\& )
(\\) *
casillaEspecial\\* 9
)\\9 :
;\\: ;
}]] 
}^^ 	
privatebb 
voidbb 
ColocarPortalesbb $
(bb$ %
)bb% &
{cc 	
ServidorJuegoSEdd 
.dd 
Casilladd #
casilladd$ +
;dd+ ,
Imageee 
imagenPortalee 
;ee 
forff 
(ff 
intff 
iff 
=ff 
$numff 
;ff 
iff 
<ff 
Portalesff  (
.ff( )
Countff) .
;ff. /
iff0 1
++ff1 3
)ff3 4
{gg 
casillahh 
=hh 
Casillashh "
.hh" #
Findhh# '
(hh' (
xhh( )
=>hh* ,
xhh- .
.hh. /
Idhh/ 1
==hh2 4
Portaleshh5 =
[hh= >
ihh> ?
]hh? @
.hh@ A
	IdCasillahhA J
)hhJ K
;hhK L
imagenPortalii 
=ii 
newii "
Imageii# (
(ii( )
)ii) *
;ii* +
imagenPortaljj 
.jj 
Sourcejj #
=jj$ %
newjj& )
BitmapImagejj* 5
(jj5 6
newjj6 9
Urijj: =
(jj= >
Portalesjj> F
[jjF G
ijjG H
]jjH I
.jjI J
	UriPortaljjJ S
,jjS T
UriKindjjU \
.jj\ ]
Relativejj] e
)jje f
)jjf g
;jjg h
imagenPortalkk 
.kk 
HorizontalAlignmentkk 0
=kk1 2
HorizontalAlignmentkk3 F
.kkF G
LeftkkG K
;kkK L
imagenPortalll 
.ll 
VerticalAlignmentll .
=ll/ 0
VerticalAlignmentll1 B
.llB C
BottomllC I
;llI J
imagenPortalmm 
.mm 
Heightmm #
=mm$ %
$nummm& (
;mm( )
imagenPortalnn 
.nn 
Namenn !
=nn" #
Portalesnn$ ,
[nn, -
inn- .
]nn. /
.nn/ 0
Colornn0 5
+nn6 7
Portalesnn8 @
[nn@ A
innA B
]nnB C
.nnC D
ZonaTableronnD O
;nnO P
Gridoo 
.oo 
SetRowoo 
(oo 
imagenPortaloo (
,oo( )
casillaoo* 1
.oo1 2
Filaoo2 6
)oo6 7
;oo7 8
Gridpp 
.pp 
	SetColumnpp 
(pp 
imagenPortalpp +
,pp+ ,
casillapp- 4
.pp4 5
Columnapp5 <
)pp< =
;pp= >
grid_Tableroqq 
.qq 
Childrenqq %
.qq% &
Addqq& )
(qq) *
imagenPortalqq* 6
)qq6 7
;qq7 8
}rr 
}ss 	
privateuu 
voiduu 
Button_Enviaruu "
(uu" #
objectuu# )
senderuu* 0
,uu0 1
RoutedEventArgsuu2 A
euuB C
)uuC D
{vv 	
ifww 
(ww 
textBox_Mensajeww 
.ww  
Textww  $
!=ww% '
$strww( *
)ww* +
{xx 
ClienteMultijugadoryy #
.yy# $
EnviarMensajeJuegoyy$ 6
(yy6 7
Salayy7 ;
.yy; <
IdSalayy< B
,yyB C
textBox_MensajeyyD S
.yyS T
TextyyT X
)yyX Y
;yyY Z
textBox_Mensajezz 
.zz  
Clearzz  %
(zz% &
)zz& '
;zz' (
}{{ 
}|| 	
private~~ 
void~~ 
CerrarVentana~~ "
(~~" #
object~~# )
sender~~* 0
,~~0 1
System~~2 8
.~~8 9
ComponentModel~~9 G
.~~G H
CancelEventArgs~~H W
e~~X Y
)~~Y Z
{ 	
musicaFondo
ÄÄ 
.
ÄÄ 
Stop
ÄÄ 
(
ÄÄ 
)
ÄÄ 
;
ÄÄ !
ClienteMultijugador
ÅÅ 
.
ÅÅ  

SalirJuego
ÅÅ  *
(
ÅÅ* +
Sala
ÅÅ+ /
.
ÅÅ/ 0
IdSala
ÅÅ0 6
)
ÅÅ6 7
;
ÅÅ7 8
}
ÇÇ 	
private
ÑÑ 
void
ÑÑ 
Button_Salir
ÑÑ !
(
ÑÑ! "
object
ÑÑ" (
sender
ÑÑ) /
,
ÑÑ/ 0
RoutedEventArgs
ÑÑ1 @
e
ÑÑA B
)
ÑÑB C
{
ÖÖ 	
MenuPrincipal
ÜÜ 
menuPrincipal
ÜÜ '
=
ÜÜ( )
new
ÜÜ* -
MenuPrincipal
ÜÜ. ;
(
ÜÜ; <
Jugador
ÜÜ< C
)
ÜÜC D
;
ÜÜD E
menuPrincipal
áá 
.
áá 
Show
áá 
(
áá 
)
áá  
;
áá  !
this
àà 
.
àà 
Close
àà 
(
àà 
)
àà 
;
àà 
}
ââ 	
public
ãã 
void
ãã #
RecibirListaJugadores
ãã )
(
ãã) *
List
ãã* .
<
ãã. /
String
ãã/ 5
>
ãã5 6
	jugadores
ãã7 @
)
ãã@ A
{
åå 	!
JugadoresConectados
çç 
.
çç  
AddRange
çç  (
(
çç( )
	jugadores
çç) 2
)
çç2 3
;
çç3 4)
listBox_JugadoresConectados
éé '
.
éé' (
Items
éé( -
.
éé- .
Refresh
éé. 5
(
éé5 6
)
éé6 7
;
éé7 8
}
èè 	
public
ëë 
void
ëë 
Entrar
ëë 
(
ëë 
)
ëë 
{
íí 	!
ClienteMultijugador
ìì 
.
ìì  
UnirseJuego
ìì  +
(
ìì+ ,
Sala
ìì, 0
.
ìì0 1
IdSala
ìì1 7
,
ìì7 8
Jugador
ìì9 @
)
ìì@ A
;
ììA B
}
îî 	
public
ôô 
void
ôô 

MoverFicha
ôô 
(
ôô 
bool
ôô #

cayoPortal
ôô$ .
)
ôô. /
{
öö 	
ServidorJuegoSE
õõ 
.
õõ 
Casilla
õõ #
casillaTemporal
õõ$ 3
=
õõ4 5
Casillas
õõ6 >
.
õõ> ?
	ElementAt
õõ? H
(
õõH I
JugadorEnTurno
õõI W
.
õõW X
Posicion
õõX `
-
õõa b
$num
õõc d
)
õõd e
;
õõe f
var
úú 
imagenesTablero
úú 
=
úú  !
grid_Tablero
úú" .
.
úú. /
Children
úú/ 7
.
úú7 8
Cast
úú8 <
<
úú< =
	UIElement
úú= F
>
úúF G
(
úúG H
)
úúH I
.
úúI J
Where
úúJ O
(
úúO P
i
úúP Q
=>
úúR T
i
úúU V
is
úúW Y
Image
úúZ _
)
úú_ `
.
úú` a
Cast
úúa e
<
úúe f
Image
úúf k
>
úúk l
(
úúl m
)
úúm n
;
úún o
var
ùù 
fichaAMover
ùù 
=
ùù 
imagenesTablero
ùù -
.
ùù- .
FirstOrDefault
ùù. <
(
ùù< =
i
ùù= >
=>
ùù? A
i
ùùB C
.
ùùC D
Name
ùùD H
==
ùùI K
JugadorEnTurno
ùùL Z
.
ùùZ [
NombreFicha
ùù[ f
)
ùùf g
;
ùùg h
Grid
ûû 
.
ûû 
	SetColumn
ûû 
(
ûû 
fichaAMover
ûû &
,
ûû& '
casillaTemporal
ûû( 7
.
ûû7 8
Columna
ûû8 ?
)
ûû? @
;
ûû@ A
Grid
üü 
.
üü 
SetRow
üü 
(
üü 
fichaAMover
üü #
,
üü# $
casillaTemporal
üü% 4
.
üü4 5
Fila
üü5 9
)
üü9 :
;
üü: ;
var
†† 
portal
†† 
=
†† 
Portales
†† !
.
††! "
Find
††" &
(
††& '
x
††' (
=>
††) +
x
††, -
.
††- .
	IdCasilla
††. 7
==
††8 :
casillaTemporal
††; J
.
††J K
Id
††K M
)
††M N
;
††N O
if
°° 
(
°° 
portal
°° 
!=
°° 
null
°° 
&&
°° !
!
°°" #

cayoPortal
°°# -
)
°°- .
{
¢¢ 
var
££ 

otroPortal
££ 
=
££  
Portales
££! )
.
££) *
Find
££* .
(
££. /
x
££/ 0
=>
££1 3
x
££4 5
.
££5 6
Color
££6 ;
==
££< >
portal
££? E
.
££E F
Color
££F K
&&
££L N
x
££O P
.
££P Q
ZonaTablero
££Q \
!=
££] _
portal
££` f
.
££f g
ZonaTablero
££g r
)
££r s
;
££s t
JugadorEnTurno
§§ 
.
§§ 
Posicion
§§ '
=
§§( )

otroPortal
§§* 4
.
§§4 5
	IdCasilla
§§5 >
;
§§> ?
if
•• 
(
•• 
JugadorEnTurno
•• "
.
••" #
ApodoJugador
••# /
==
••0 2
Jugador
••3 :
.
••: ;
Apodo
••; @
)
••@ A
{
¶¶ !
ClienteMultijugador
ßß '
.
ßß' ("
CambiarPosicionFicha
ßß( <
(
ßß< =
Sala
ßß= A
.
ßßA B
IdSala
ßßB H
,
ßßH I
JugadorEnTurno
ßßJ X
)
ßßX Y
;
ßßY Z
}
®® 
DispatcherTimer
©© 
temporizador
©©  ,
=
©©- .
new
©©/ 2
DispatcherTimer
©©3 B
(
©©B C
)
©©C D
;
©©D E
temporizador
™™ 
.
™™ 
Interval
™™ %
=
™™& '
TimeSpan
™™( 0
.
™™0 1
FromSeconds
™™1 <
(
™™< =
$num
™™= ?
)
™™? @
;
™™@ A
temporizador
´´ 
.
´´ 
Tick
´´ !
+=
´´" $"
TemporizadorDetenido
´´% 9
;
´´9 :
temporizador
¨¨ 
.
¨¨ 
Start
¨¨ "
(
¨¨" #
)
¨¨# $
;
¨¨$ %
}
≠≠ 
if
ÆÆ 
(
ÆÆ 
casillaTemporal
ÆÆ 
.
ÆÆ  
Especial
ÆÆ  (
&&
ÆÆ) +
JugadorEnTurno
ÆÆ, :
.
ÆÆ: ;
ApodoJugador
ÆÆ; G
==
ÆÆH J
Jugador
ÆÆK R
.
ÆÆR S
Apodo
ÆÆS X
)
ÆÆX Y
{
ØØ !
ClienteMultijugador
∞∞ #
.
∞∞# $
CambiarPortales
∞∞$ 3
(
∞∞3 4
Sala
∞∞4 8
.
∞∞8 9
IdSala
∞∞9 ?
,
∞∞? @
Casillas
∞∞A I
.
∞∞I J
ToArray
∞∞J Q
(
∞∞Q R
)
∞∞R S
,
∞∞S T
Portales
∞∞U ]
.
∞∞] ^
ToArray
∞∞^ e
(
∞∞e f
)
∞∞f g
)
∞∞g h
;
∞∞h i
}
±± 
}
≤≤ 	
private
¥¥ 
void
¥¥ "
TemporizadorDetenido
¥¥ )
(
¥¥) *
object
¥¥* 0
sender
¥¥1 7
,
¥¥7 8
	EventArgs
¥¥9 B
e
¥¥C D
)
¥¥D E
{
µµ 	
var
∂∂ 
temporizador
∂∂ 
=
∂∂ 
sender
∂∂ %
as
∂∂& (
DispatcherTimer
∂∂) 8
;
∂∂8 9
temporizador
∑∑ 
.
∑∑ 
Stop
∑∑ 
(
∑∑ 
)
∑∑ 
;
∑∑  

MoverFicha
∏∏ 
(
∏∏ 
true
∏∏ 
)
∏∏ 
;
∏∏ 
}
ππ 	
public
ΩΩ 
void
ΩΩ #
MostrarFichaEnTablero
ΩΩ )
(
ΩΩ) *
)
ΩΩ* +
{
ææ 	
Image
øø 
imagenFicha
øø 
=
øø 
new
øø  #
Image
øø$ )
(
øø) *
)
øø* +
;
øø+ ,
imagenFicha
¿¿ 
.
¿¿ 
Source
¿¿ 
=
¿¿  
new
¿¿! $
BitmapImage
¿¿% 0
(
¿¿0 1
new
¿¿1 4
Uri
¿¿5 8
(
¿¿8 9
JugadorEnTurno
¿¿9 G
.
¿¿G H
UriFicha
¿¿H P
,
¿¿P Q
UriKind
¿¿R Y
.
¿¿Y Z
Relative
¿¿Z b
)
¿¿b c
)
¿¿c d
;
¿¿d e
imagenFicha
¡¡ 
.
¡¡ 
Name
¡¡ 
=
¡¡ 
JugadorEnTurno
¡¡ -
.
¡¡- .
NombreFicha
¡¡. 9
;
¡¡9 :
imagenFicha
¬¬ 
.
¬¬ 
Width
¬¬ 
=
¬¬ 
$num
¬¬  "
;
¬¬" #
imagenFicha
√√ 
.
√√ 
Height
√√ 
=
√√  
$num
√√! #
;
√√# $
grid_Tablero
ƒƒ 
.
ƒƒ 
Children
ƒƒ !
.
ƒƒ! "
Add
ƒƒ" %
(
ƒƒ% &
imagenFicha
ƒƒ& 1
)
ƒƒ1 2
;
ƒƒ2 3
Grid
≈≈ 
.
≈≈ 
	SetColumn
≈≈ 
(
≈≈ 
imagenFicha
≈≈ &
,
≈≈& '
$num
≈≈( )
)
≈≈) *
;
≈≈* +
Grid
∆∆ 
.
∆∆ 
SetRow
∆∆ 
(
∆∆ 
imagenFicha
∆∆ #
,
∆∆# $
$num
∆∆% &
)
∆∆& '
;
∆∆' (
}
«« 	
public
ÃÃ 
void
ÃÃ 
CambiarPortales
ÃÃ #
(
ÃÃ# $
ServidorJuegoSE
ÃÃ$ 3
.
ÃÃ3 4
Portal
ÃÃ4 :
[
ÃÃ: ;
]
ÃÃ; <
portalesRecibidos
ÃÃ= N
)
ÃÃN O
{
ÕÕ 	
for
ŒŒ 
(
ŒŒ 
int
ŒŒ 
i
ŒŒ 
=
ŒŒ 
$num
ŒŒ 
;
ŒŒ 
i
ŒŒ 
<
ŒŒ 
Portales
ŒŒ  (
.
ŒŒ( )
Count
ŒŒ) .
;
ŒŒ. /
i
ŒŒ0 1
++
ŒŒ1 3
)
ŒŒ3 4
{
œœ 
var
–– 
casillaDelPortal
–– $
=
––% &
Casillas
––' /
.
––/ 0
Find
––0 4
(
––4 5
x
––5 6
=>
––7 9
x
––: ;
.
––; <
Id
––< >
==
––? A
Portales
––B J
[
––J K
i
––K L
]
––L M
.
––M N
	IdCasilla
––N W
)
––W X
;
––X Y
var
—— 
imagenesEnCasilla
—— %
=
——& '
grid_Tablero
——( 4
.
——4 5
Children
——5 =
.
——= >
Cast
——> B
<
——B C
	UIElement
——C L
>
——L M
(
——M N
)
——N O
.
——O P
Where
——P U
(
““ 
x
““ 
=>
““ 
x
““ 
is
““ 
Image
““ $
&&
““% '
Grid
““( ,
.
““, -
	GetColumn
““- 6
(
““6 7
x
““7 8
)
““8 9
==
““: <
casillaDelPortal
““= M
.
““M N
Columna
““N U
&&
”” 
Grid
”” 
.
”” 
GetRow
”” "
(
””" #
x
””# $
)
””$ %
==
””& (
casillaDelPortal
””) 9
.
””9 :
Fila
””: >
)
””> ?
.
””? @
Cast
””@ D
<
””D E
Image
””E J
>
””J K
(
””K L
)
””L M
;
””M N
var
‘‘ 
portal
‘‘ 
=
‘‘ 
imagenesEnCasilla
‘‘ .
.
‘‘. /
FirstOrDefault
‘‘/ =
(
‘‘= >
x
‘‘> ?
=>
‘‘@ B
x
‘‘C D
.
‘‘D E
Name
‘‘E I
.
‘‘I J
Equals
‘‘J P
(
‘‘P Q
Portales
‘‘Q Y
[
‘‘Y Z
i
‘‘Z [
]
‘‘[ \
.
‘‘\ ]
Color
‘‘] b
+
‘‘c d
Portales
‘‘e m
[
‘‘m n
i
‘‘n o
]
‘‘o p
.
‘‘p q
ZonaTablero
‘‘q |
)
‘‘| }
)
‘‘} ~
;
‘‘~ 
var
’’ 
nuevaCasilla
’’  
=
’’! "
Casillas
’’# +
.
’’+ ,
Find
’’, 0
(
’’0 1
x
’’1 2
=>
’’3 5
x
’’6 7
.
’’7 8
Id
’’8 :
==
’’; =
portalesRecibidos
’’> O
[
’’O P
i
’’P Q
]
’’Q R
.
’’R S
	IdCasilla
’’S \
)
’’\ ]
;
’’] ^
Grid
÷÷ 
.
÷÷ 
SetRow
÷÷ 
(
÷÷ 
portal
÷÷ "
,
÷÷" #
nuevaCasilla
÷÷$ 0
.
÷÷0 1
Fila
÷÷1 5
)
÷÷5 6
;
÷÷6 7
Grid
◊◊ 
.
◊◊ 
	SetColumn
◊◊ 
(
◊◊ 
portal
◊◊ %
,
◊◊% &
nuevaCasilla
◊◊' 3
.
◊◊3 4
Columna
◊◊4 ;
)
◊◊; <
;
◊◊< =
}
ÿÿ 
Portales
ŸŸ 
=
ŸŸ 
portalesRecibidos
ŸŸ (
.
ŸŸ( )
ToList
ŸŸ) /
(
ŸŸ/ 0
)
ŸŸ0 1
;
ŸŸ1 2
}
⁄⁄ 	
private
‡‡ 
void
‡‡ 
ValidarTexto
‡‡ !
(
‡‡! "
object
‡‡" (
sender
‡‡) /
,
‡‡/ 0
RoutedEventArgs
‡‡1 @
e
‡‡A B
)
‡‡B C
{
·· 	
var
‚‚ 
textbox
‚‚ 
=
‚‚ 
sender
‚‚  
as
‚‚! #
TextBox
‚‚$ +
;
‚‚+ ,
if
„„ 
(
„„ 
textbox
„„ 
.
„„ 
Text
„„ 
==
„„ 
$str
„„  "
)
„„" #
{
‰‰ 
return
ÂÂ 
;
ÂÂ 
}
ÊÊ 
if
ÁÁ 
(
ÁÁ 
!
ÁÁ 
Regex
ÁÁ 
.
ÁÁ 
IsMatch
ÁÁ 
(
ÁÁ 
textbox
ÁÁ &
.
ÁÁ& '
Text
ÁÁ' +
,
ÁÁ+ ,
$str
ÁÁ- ?
)
ÁÁ? @
)
ÁÁ@ A
{
ËË 

MessageBox
ÈÈ 
.
ÈÈ 
Show
ÈÈ 
(
ÈÈ  

Properties
ÈÈ  *
.
ÈÈ* +
	Resources
ÈÈ+ 4
.
ÈÈ4 5
camposInvalidos
ÈÈ5 D
)
ÈÈD E
;
ÈÈE F
textbox
ÍÍ 
.
ÍÍ 
Clear
ÍÍ 
(
ÍÍ 
)
ÍÍ 
;
ÍÍ  
}
ÎÎ 
}
ÏÏ 	
}
ÌÌ 
}ÓÓ ∑
rC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\MenuPrincipal.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
MenuPrincipal &
:' (
Window) /
{0 1
private		 
ServidorJuegoSE		 
.		  
Jugador		  '
jugador		( /
;		/ 0
private

 
SoundPlayer

 
sonidoBoton

 '
=

( )
new

* -
SoundPlayer

. 9
(

9 :
$str

: S
)

S T
;

T U
public 
MenuPrincipal 
( 
ServidorJuegoSE ,
., -
Jugador- 4
jugadorRecibido5 D
)D E
{F G
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
} 	
private 
void $
Button_ConsultarPuntajes -
(- .
object. 4
sender5 ;
,; <
RoutedEventArgs= L
eM N
)N O
{P Q
sonidoBoton 
. 
Play 
( 
) 
; 
ConsultarPuntajes 
ventanaPuntajes -
=. /
new0 3
ConsultarPuntajes4 E
(E F
jugadorF M
)M N
;N O
ventanaPuntajes 
. 
Show  
(  !
)! "
;" #
this 
. 
Close 
( 
) 
; 
} 	
private 
void 
Button_CerrarSesion (
(( )
object) /
sender0 6
,6 7
RoutedEventArgs8 G
eH I
)I J
{K L
sonidoBoton 
. 
Play 
( 
) 
; 

MainWindow 
ventanaIncio #
=$ %
new& )

MainWindow* 4
(4 5
)5 6
;6 7
ventanaIncio 
. 
Show 
( 
) 
;  
this 
. 
Close 
( 
) 
; 
}   	
private"" 
void"" 
Button_NuevaPartida"" (
(""( )
object"") /
sender""0 6
,""6 7
RoutedEventArgs""8 G
e""H I
)""I J
{## 	
sonidoBoton$$ 
.$$ 
Play$$ 
($$ 
)$$ 
;$$ 
CrearPartida%% 
ventanaCrearPartida%% ,
=%%- .
new%%/ 2
CrearPartida%%3 ?
(%%? @
jugador%%@ G
)%%G H
;%%H I
ventanaCrearPartida&& 
.&&  
Show&&  $
(&&$ %
)&&% &
;&&& '
this'' 
.'' 
Close'' 
('' 
)'' 
;'' 
}(( 	
private** 
void**  
Button_BuscarPartida** )
(**) *
object*** 0
sender**1 7
,**7 8
RoutedEventArgs**9 H
e**I J
)**J K
{++ 	
sonidoBoton,, 
.,, 
Play,, 
(,, 
),, 
;,, 
BuscarPartida--  
ventanaBuscarPartida-- .
=--/ 0
new--1 4
BuscarPartida--5 B
(--B C
jugador--C J
)--J K
;--K L 
ventanaBuscarPartida..  
...  !
Show..! %
(..% &
)..& '
;..' (
this// 
.// 
Close// 
(// 
)// 
;// 
}00 	
}22 
}33 Í]
tC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\RegistroUsuario.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
RegistroUsuario (
:) *
Window+ 1
{ 
public 
RegistroUsuario 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
enum 
EstadoDeOperacion 
{ 	
OperacionExitosa 
= 
$num  
,  !
ErrorConexionBD 
= 
- 
$num !
,! "
	Excepcion 
= 
- 
$num 
, 
JugadorEncontrado 
= 
-  !
$num! "
," #
CuentaEncontrada 
= 
-  
$num  !
,! "
} 	
private## 
void## 
Button_Regresar## $
(##$ %
object##% +
sender##, 2
,##2 3
RoutedEventArgs##4 C
e##D E
)##E F
{##G H

MainWindow$$ 
ventanaPrincipal$$ '
=$$( )
new$$* -

MainWindow$$. 8
($$8 9
)$$9 :
;$$: ;
ventanaPrincipal%% 
.%% 
Show%% !
(%%! "
)%%" #
;%%# $
this&& 
.&& 
Close&& 
(&& 
)&& 
;&& 
}'' 	
private11 
void11 
Button_Registrarse11 '
(11' (
object11( .
sender11/ 5
,115 6
RoutedEventArgs117 F
e11G H
)11H I
{11J K
if22 
(22 
!22 
ValidarCampos22 
(22 
)22  
||22! #
!22$ % 
ValidarFormatoCorreo22% 9
(229 :
)22: ;
)22; <
{33 
return44 
;44 
}55 
ServidorJuegoSE66 
.66 %
AdministradorCuentaClient66 5
cliente666 =
=66> ?
new66@ C
ServidorJuegoSE66D S
.66S T%
AdministradorCuentaClient66T m
(66m n
)66n o
;66o p
ServidorJuegoSE77 
.77 
Cuenta77 "
cuenta77# )
=77* +
new77, /
ServidorJuegoSE770 ?
.77? @
Cuenta77@ F
(77F G
)77G H
{77I J
Correo77K Q
=77R S%
textBox_CorreoElectronico77T m
.77m n
Text77n r
,77r s
Contrase√±a77t ~
=	77 Ä%
passwordBox_Contrase√±a
77Å ó
.
77ó ò
Password
77ò †
}
77° ¢
;
77¢ £
ServidorJuegoSE88 
.88 
Jugador88 #
jugador88$ +
=88, -
new88. 1
ServidorJuegoSE882 A
.88A B
Jugador88B I
(88I J
)88J K
{88L M
Apodo88N S
=88T U
textBox_Apodo88V c
.88c d
Text88d h
,88h i
Nombre88j p
=88q r"
textBox_NombreUsuario	88s à
.
88à â
Text
88â ç
,
88ç é
	Apellidos
88è ò
=
88ô ö
textBox_Apellidos
88õ ¨
.
88¨ ≠
Text
88≠ ±
}
88≤ ≥
;
88≥ ¥
int99 
	respuesta99 
;99 
try:: 
{;; 
	respuesta<< 
=<< 
cliente<< #
.<<# $
RegistrarJugador<<$ 4
(<<4 5
jugador<<5 <
,<<< =
cuenta<<> D
)<<D E
;<<E F
if== 
(== 
	respuesta== 
====  
(==! "
int==" %
)==% &
EstadoDeOperacion==& 7
.==7 8
OperacionExitosa==8 H
)==H I
{>> 
cliente?? 
.?? 
EnviarCorreo?? (
(??( )
cuenta??) /
)??/ 0
;??0 1
IngresarCodigo@@ "
ingresarCodigo@@# 1
=@@2 3
new@@4 7
IngresarCodigo@@8 F
(@@F G
cuenta@@G M
)@@M N
;@@N O
ingresarCodigoAA "
.AA" #
ShowAA# '
(AA' (
)AA( )
;AA) *
thisBB 
.BB 
CloseBB 
(BB 
)BB  
;BB  !
}CC 
}DD 
catchEE 
(EE 
SystemEE 
.EE 
ServiceModelEE &
.EE& '%
EndpointNotFoundExceptionEE' @
)EE@ A
{FF 

MessageBoxGG 
.GG 
ShowGG 
(GG  

PropertiesGG  *
.GG* +
	ResourcesGG+ 4
.GG4 5!
errorConexionServidorGG5 J
,GGJ K

PropertiesGGL V
.GGV W
	ResourcesGGW `
.GG` a
tituloErrorConexionGGa t
,GGt u
MessageBoxButton	GGv Ü
.
GGÜ á
OK
GGá â
,
GGâ ä
MessageBoxImage
GGã ö
.
GGö õ
Error
GGõ †
)
GG† °
;
GG° ¢
returnHH 
;HH 
}II 
ifJJ 
(JJ 
	respuestaJJ 
==JJ 
(JJ 
intJJ !
)JJ! "
EstadoDeOperacionJJ" 3
.JJ3 4
JugadorEncontradoJJ4 E
)JJE F
{KK 
stringLL 
usuarioRepetidoLL &
=LL' (

PropertiesLL) 3
.LL3 4
	ResourcesLL4 =
.LL= >
usuarioRepetidoLL> M
;LLM N

MessageBoxMM 
.MM 
ShowMM 
(MM  
usuarioRepetidoMM  /
)MM/ 0
;MM0 1
returnNN 
;NN 
}OO 
ifPP 
(PP 
	respuestaPP 
==PP 
(PP 
intPP !
)PP! "
EstadoDeOperacionPP" 3
.PP3 4
CuentaEncontradaPP4 D
)PPD E
{QQ 
stringRR 
correoRepetidoRR %
=RR& '

PropertiesRR( 2
.RR2 3
	ResourcesRR3 <
.RR< =
correoRepetidoRR= K
;RRK L

MessageBoxSS 
.SS 
ShowSS 
(SS  
correoRepetidoSS  .
)SS. /
;SS/ 0
returnTT 
;TT 
}UU 
ifVV 
(VV 
	respuestaVV 
==VV 
(VV 
intVV !
)VV! "
EstadoDeOperacionVV" 3
.VV3 4
ErrorConexionBDVV4 C
||VVD F
	respuestaVVG P
==VVQ S
(VVT U
intVVU X
)VVX Y
EstadoDeOperacionVVY j
.VVj k
	ExcepcionVVk t
)VVt u
{WW 

MessageBoxXX 
.XX 
ShowXX 
(XX  

PropertiesXX  *
.XX* +
	ResourcesXX+ 4
.XX4 5"
errorConexionBaseDatosXX5 K
,XXK L

PropertiesXXM W
.XXW X
	ResourcesXXX a
.XXa b
tituloErrorConexionXXb u
,XXu v
MessageBoxButton	XXw á
.
XXá à
OK
XXà ä
,
XXä ã
MessageBoxImage
XXå õ
.
XXõ ú
Error
XXú °
)
XX° ¢
;
XX¢ £
}YY 
}ZZ 	
privatebb 
Booleanbb 
ValidarCamposbb %
(bb% &
)bb& '
{bb( )
ifdd 
(dd !
textBox_NombreUsuariodd %
.dd% &
Textdd& *
==dd+ -
$strdd. 0
||dd1 3
textBox_Apellidosdd4 E
.ddE F
TextddF J
==ddK M
$strddM O
||ddP R
textBox_ApododdS `
.dd` a
Textdda e
==dde g
$strddh j
||ddk m&
textBox_CorreoElectronico	ddn á
.
ddá à
Text
ddà å
==
ddç è
$str
ddè ë
||ee #
passwordBox_Contrase√±aee )
.ee) *
SecurePasswordee* 8
.ee8 9
Lengthee9 ?
==ee@ B
$numeeC D
||eeE G,
 passwordBox_ConfirmarContrase√±aeeH g
.eeg h
SecurePasswordeeh v
.eev w
Lengtheew }
==	ee~ Ä
$num
eeÅ Ç
)
eeÇ É
{
eeÑ Ö
stringff 
camposObligatoriosff )
=ff* +

Propertiesff, 6
.ff6 7
	Resourcesff7 @
.ff@ A
camposObligatoriosffA S
;ffS T

MessageBoxgg 
.gg 
Showgg 
(gg  
camposObligatoriosgg  2
)gg2 3
;gg3 4
returnhh 
falsehh 
;hh 
}ii 
elsejj 
ifjj 
(jj 
!jj #
passwordBox_Contrase√±ajj ,
.jj, -
Passwordjj- 5
.jj5 6
Equalsjj6 <
(jj< =,
 passwordBox_ConfirmarContrase√±ajj= \
.jj\ ]
Passwordjj] e
)jje f
)jjf g
{kk 
stringll 
contrase√±aInvalidall )
=ll* +

Propertiesll, 6
.ll6 7
	Resourcesll7 @
.ll@ A!
contrase√±aNoCoincidellA U
;llU V

MessageBoxmm 
.mm 
Showmm 
(mm  
contrase√±aInvalidamm  2
)mm2 3
;mm3 4
returnnn 
falsenn 
;nn 
}oo 
returnpp 
truepp 
;pp 
}qq 	
privateww 
Booleanww  
ValidarFormatoCorreoww ,
(ww, -
)ww- .
{xx 	
Stringyy 
	expresionyy 
=yy 
$stryy T
;yyT U
ifzz 
(zz 
Regexzz 
.zz 
IsMatchzz 
(zz %
textBox_CorreoElectronicozz 7
.zz7 8
Textzz8 <
,zz< =
	expresionzz> G
)zzG H
&&zzH J
RegexzzK P
.zzP Q
ReplacezzQ X
(zzX Y%
textBox_CorreoElectronicozzY r
.zzr s
Textzzs w
,zzw x
	expresion	zzy Ç
,
zzÇ É
String
zzÑ ä
.
zzä ã
Empty
zzã ê
)
zzê ë
.
zzë í
Length
zzí ò
==
zzô õ
$num
zzú ù
)
zzù û
{{{ 
return|| 
true|| 
;|| 
}}} 

MessageBox~~ 
.~~ 
Show~~ 
(~~ 

Properties~~ &
.~~& '
	Resources~~' 0
.~~0 1
correoInvalido~~1 ?
)~~? @
;~~@ A
return 
false 
; 
}
ÄÄ 	
private
ÇÇ 
void
ÇÇ 
ValidarTexto
ÇÇ !
(
ÇÇ! "
object
ÇÇ" (
sender
ÇÇ) /
,
ÇÇ/ 0
RoutedEventArgs
ÇÇ1 @
e
ÇÇA B
)
ÇÇB C
{
ÉÉ 	
var
ÑÑ 
textbox
ÑÑ 
=
ÑÑ 
sender
ÑÑ  
as
ÑÑ! #
TextBox
ÑÑ$ +
;
ÑÑ+ ,
if
ÖÖ 
(
ÖÖ 
textbox
ÖÖ 
.
ÖÖ 
Text
ÖÖ 
==
ÖÖ 
$str
ÖÖ  "
)
ÖÖ" #
{
ÜÜ 
return
áá 
;
áá 
}
àà 
if
ââ 
(
ââ 
!
ââ 
Regex
ââ 
.
ââ 
IsMatch
ââ "
(
ââ" #
textbox
ââ# *
.
ââ* +
Text
ââ+ /
,
ââ/ 0
$str
ââ1 C
)
ââC D
)
ââD E
{
ää 

MessageBox
ãã 
.
ãã 
Show
ãã 
(
ãã  

Properties
ãã  *
.
ãã* +
	Resources
ãã+ 4
.
ãã4 5
camposInvalidos
ãã5 D
)
ããD E
;
ããE F
textbox
åå 
.
åå 
Clear
åå 
(
åå 
)
åå 
;
åå  
}
çç 
}
éé 	
}
èè 
}êê ÜO
jC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Lobby.xaml.cs
	namespace		 	
SerpientesEscaleras		
 
{

 
public 

partial 
class 
Lobby 
:  
Window! '
{ 
private 
ServidorJuegoSE 
.  
Jugador  '
jugador( /
;/ 0
InstanceContext 
contexto  
;  !
private 
ServidorJuegoSE 
.  +
AdministradorMultijugadorClient  ?
clienteMultijugador@ S
;S T
private  
CallbackMultijugador $
regresoMensaje% 3
;3 4
private 
ServidorJuegoSE 
.  
Sala  $
sala% )
;) *
public 
List 
< 
string 
> 
Chat  
{! "
get# &
;& '
set( +
;+ ,
}- .
=/ 0
new1 4
List5 9
<9 :
string: @
>@ A
(A B
)B C
;C D
public 
List 
< 
string 
> 
JugadoresConectados /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
=> ?
new@ C
ListD H
<H I
StringI O
>O P
(P Q
)Q R
;R S
public 
Lobby 
( 
ServidorJuegoSE $
.$ %
Jugador% ,
jugadorRecibido- <
)< =
{ 	
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
listBox_Chat   
.   
ItemsSource   $
=  % &
Chat  ' +
;  + ,'
listBox_JugadoresConectados!! '
.!!' (
ItemsSource!!( 3
=!!4 5
JugadoresConectados!!6 I
;!!I J
regresoMensaje"" 
="" 
new""   
CallbackMultijugador""! 5
{## 
Lobby$$ 
=$$ 
this$$ 
}%% 
;%% 
contexto&& 
=&& 
new&& 
InstanceContext&& *
(&&* +
regresoMensaje&&+ 9
)&&9 :
;&&: ;
clienteMultijugador'' 
=''  !
new''" %
ServidorJuegoSE''& 5
.''5 6+
AdministradorMultijugadorClient''6 U
(''U V
contexto''V ^
)''^ _
;''_ `
}(( 	
public.. 
void.. 
CrearPartida..  
(..  !
ServidorJuegoSE..! 0
...0 1
Sala..1 5
salaRecibida..6 B
)..B C
{// 	
sala00 
=00 
salaRecibida00 
;00  
sala11 
.11 
IdSala11 
=11 
clienteMultijugador11 -
.11- .
	CrearSala11. 7
(117 8
sala118 <
)11< =
;11= >
clienteMultijugador22 
.22  

UnirseSala22  *
(22* +
sala22+ /
.22/ 0
IdSala220 6
,226 7
jugador228 ?
)22? @
;22@ A
}33 	
public:: 
Boolean:: 
EntrarPartida:: $
(::$ %
ServidorJuegoSE::% 4
.::4 5
Sala::5 9
salaRecibida::: F
)::F G
{;; 	
sala<< 
=<< 
salaRecibida<< 
;<<  
if== 
(== 
clienteMultijugador== #
.==# $
ValidarSala==$ /
(==/ 0
sala==0 4
.==4 5
IdSala==5 ;
)==; <
)==< =
{>> 
JugadoresConectados?? #
=??$ %
clienteMultijugador??& 9
.??9 :"
ConsultarJugadoresSala??: P
(??P Q
sala??Q U
.??U V
IdSala??V \
)??\ ]
.??] ^
ToList??^ d
(??d e
)??e f
;??f g'
listBox_JugadoresConectados@@ +
.@@+ ,
ItemsSource@@, 7
=@@8 9
JugadoresConectados@@: M
;@@M N
clienteMultijugadorAA #
.AA# $

UnirseSalaAA$ .
(AA. /
salaAA/ 3
.AA3 4
IdSalaAA4 :
,AA: ;
jugadorAA< C
)AAC D
;AAD E
returnBB 
trueBB 
;BB 
}CC 
returnDD 
falseDD 
;DD 
}EE 	
publicKK 
ListKK 
<KK 
ServidorJuegoSEKK #
.KK# $
SalaKK$ (
>KK( )(
ConsultarPartidasDisponiblesKK* F
(KKF G
)KKG H
{LL 	
returnMM 
clienteMultijugadorMM &
.MM& '%
ConsultarSalasDisponiblesMM' @
(MM@ A
)MMA B
.MMB C
ToListMMC I
(MMI J
)MMJ K
;MMK L
}NN 	
privatePP 
voidPP 
Button_EnviarPP "
(PP" #
objectPP# )
senderPP* 0
,PP0 1
RoutedEventArgsPP2 A
ePPB C
)PPC D
{QQ 	
ifRR 
(RR 
textBox_MensajeRR 
.RR  
TextRR  $
!=RR% '
$strRR( *
)RR* +
{SS 
clienteMultijugadorTT #
.TT# $
EnviarMensajeTT$ 1
(TT1 2
salaTT2 6
.TT6 7
IdSalaTT7 =
,TT= >
textBox_MensajeTT? N
.TTN O
TextTTO S
)TTS T
;TTT U
textBox_MensajeUU 
.UU  
ClearUU  %
(UU% &
)UU& '
;UU' (
}VV 
}WW 	
privateYY 
voidYY 
CerrarVentanaYY "
(YY" #
objectYY# )
senderYY* 0
,YY0 1
SystemYY2 8
.YY8 9
ComponentModelYY9 G
.YYG H
CancelEventArgsYYH W
eYYX Y
)YYY Z
{ZZ 	
clienteMultijugador[[ 
.[[  
	SalirChat[[  )
([[) *
sala[[* .
.[[. /
IdSala[[/ 5
)[[5 6
;[[6 7
}\\ 	
private^^ 
void^^ 
Button_Regresar^^ $
(^^$ %
object^^% +
sender^^, 2
,^^2 3
RoutedEventArgs^^4 C
e^^D E
)^^E F
{__ 	
MenuPrincipal`` 
menuPrincipal`` '
=``( )
new``* -
MenuPrincipal``. ;
(``; <
jugador``< C
)``C D
;``D E
menuPrincipalaa 
.aa 
Showaa 
(aa 
)aa  
;aa  !
thisbb 
.bb 
Closebb 
(bb 
)bb 
;bb 
}cc 	
privateee 
voidee 
Button_Jugaree !
(ee! "
objectee" (
senderee) /
,ee/ 0
RoutedEventArgsee1 @
eeeA B
)eeB C
{ff 	
clienteMultijugadorgg 
.gg  
IniciarJuegogg  ,
(gg, -
salagg- 1
.gg1 2
IdSalagg2 8
)gg8 9
;gg9 :
}hh 	
publicoo 
voidoo 
EntrarJuegooo 
(oo  
ServidorJuegoSEoo  /
.oo/ 0
Casillaoo0 7
[oo7 8
]oo8 9
casillasoo: B
,ooB C
ServidorJuegoSEooD S
.ooS T
PortalooT Z
[ooZ [
]oo[ \
portalesoo] e
)ooe f
{pp 	
Juegoqq 
juegoqq 
=qq 
newqq 
Juegoqq #
(qq# $
jugadorqq$ +
,qq+ ,
salaqq- 1
,qq1 2
regresoMensajeqq3 A
)qqA B
;qqB C
juegorr 
.rr !
RecibirListaJugadoresrr '
(rr' (
JugadoresConectadosrr( ;
)rr; <
;rr< =
juegoss 
.ss 
Casillasss 
=ss 
casillasss %
.ss% &
ToListss& ,
(ss, -
)ss- .
;ss. /
juegott 
.tt 
Portalestt 
=tt 
portalestt %
.tt% &
ToListtt& ,
(tt, -
)tt- .
;tt. /
juegouu 
.uu 
InicializarTablerouu $
(uu$ %
)uu% &
;uu& '
juegovv 
.vv 
Showvv 
(vv 
)vv 
;vv 
thisww 
.ww 
Closeww 
(ww 
)ww 
;ww 
juegoxx 
.xx 
Entrarxx 
(xx 
)xx 
;xx 
}yy 	
private{{ 
void{{ 
ValidarTexto{{ !
({{! "
object{{" (
sender{{) /
,{{/ 0
RoutedEventArgs{{1 @
e{{A B
){{B C
{|| 	
var}} 
textbox}} 
=}} 
sender}}  
as}}! #
TextBox}}$ +
;}}+ ,
if~~ 
(~~ 
textbox~~ 
.~~ 
Text~~ 
==~~ 
$str~~  "
)~~" #
{ 
return
ÄÄ 
;
ÄÄ 
}
ÅÅ 
if
ÇÇ 
(
ÇÇ 
!
ÇÇ 
Regex
ÇÇ 
.
ÇÇ 
IsMatch
ÇÇ 
(
ÇÇ 
textbox
ÇÇ &
.
ÇÇ& '
Text
ÇÇ' +
,
ÇÇ+ ,
$str
ÇÇ- ?
)
ÇÇ? @
)
ÇÇ@ A
{
ÉÉ 

MessageBox
ÑÑ 
.
ÑÑ 
Show
ÑÑ 
(
ÑÑ  

Properties
ÑÑ  *
.
ÑÑ* +
	Resources
ÑÑ+ 4
.
ÑÑ4 5
camposInvalidos
ÑÑ5 D
)
ÑÑD E
;
ÑÑE F
textbox
ÖÖ 
.
ÖÖ 
Clear
ÖÖ 
(
ÖÖ 
)
ÖÖ 
;
ÖÖ  
}
ÜÜ 
}
áá 	
}
ââ 
}ää À?
rC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\BuscarPartida.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public		 

partial		 
class		 
BuscarPartida		 &
:		' (
Window		) /
{

 
private 
ServidorJuegoSE 
.  
Jugador  '
jugador( /
;/ 0
private 
Lobby 
lobby 
; 
private 
List 
< 
ServidorJuegoSE $
.$ %
Sala% )
>) *

listaSalas+ 5
;5 6
public 
BuscarPartida 
( 
ServidorJuegoSE ,
., -
Jugador- 4
jugadorRecibido5 D
)D E
{ 	
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
lobby 
= 
new 
Lobby 
( 
jugadorRecibido -
)- .
;. /

listaSalas 
= 
lobby 
. (
ConsultarPartidasDisponibles ;
(; <
)< =
;= >
dataGrid_Partidas 
. 
ItemsSource )
=* +

listaSalas, 6
;6 7
} 	
private 
void 
Button_Entrar "
(" #
object# )
sender* 0
,0 1
RoutedEventArgs2 A
eB C
)C D
{ 	
if 
( 
dataGrid_Partidas !
.! "
SelectedItem" .
==/ 1
null2 6
)6 7
{ 
string 
elegir 
= 

Properties  *
.* +
	Resources+ 4
.4 5
elegirPartida5 B
;B C

MessageBox   
.   
Show   
(    
elegir    &
)  & '
;  ' (
return!! 
;!! 
}"" 
ServidorJuegoSE## 
.## 
Sala##  
partida##! (
=##) *
(##+ ,
ServidorJuegoSE##, ;
.##; <
Sala##< @
)##@ A
dataGrid_Partidas##A R
.##R S
SelectedItem##S _
;##_ `
if$$ 
($$ 
!$$ 
lobby$$ 
.$$ 
EntrarPartida$$ $
($$$ %
partida$$% ,
)$$, -
)$$- .
{%% 

listaSalas&& 
.&& 
Clear&&  
(&&  !
)&&! "
;&&" #
string'' 
partidaRecurso'' %
=''& '

Properties''( 2
.''2 3
	Resources''3 <
.''< =
partida''= D
;''D E
string(( 
llena(( 
=(( 

Properties(( )
.(() *
	Resources((* 3
.((3 4
llena((4 9
;((9 :

MessageBox,, 
.,, 
Show,, 
(,,  
partidaRecurso,,  .
+,,/ 0
$str,,1 4
+,,5 6
partida,,7 >
.,,> ?
Nombre,,? E
+,,F G
$str,,H K
+,,L M
llena,,N S
),,S T
;,,T U

listaSalas.. 
=.. 
lobby.. "
..." #(
ConsultarPartidasDisponibles..# ?
(..? @
)..@ A
;..A B
dataGrid_Partidas// !
.//! "
Items//" '
.//' (
Refresh//( /
(/// 0
)//0 1
;//1 2
return00 
;00 
}11 
lobby22 
.22 
Show22 
(22 
)22 
;22 
this33 
.33 
Close33 
(33 
)33 
;33 
}44 	
private66 
void66 
Button_Regresar66 $
(66$ %
object66% +
sender66, 2
,662 3
RoutedEventArgs664 C
e66D E
)66E F
{77 	
MenuPrincipal88  
ventanaMenuPrincipal88 .
=88/ 0
new881 4
MenuPrincipal885 B
(88B C
jugador88C J
)88J K
;88K L 
ventanaMenuPrincipal99  
.99  !
Show99! %
(99% &
)99& '
;99' (
this:: 
.:: 
Close:: 
(:: 
):: 
;:: 
};; 	
private== 
void== 2
&DataGrid_Partidas_AutoGeneratingColumn== ;
(==; <
object==< B
sender==C I
,==I J1
%DataGridAutoGeneratingColumnEventArgs==K p
e==q r
)==r s
{>> 	
string?? 
titulo?? 
=?? 
e?? 
.?? 
Column?? $
.??$ %
Header??% +
.??+ ,
ToString??, 4
(??4 5
)??5 6
;??6 7
if@@ 
(@@ 
titulo@@ 
==@@ 
$str@@ (
||@@) +
titulo@@, 2
==@@3 5
$str@@6 G
||@@H J
titulo@@K Q
==@@R T
$str@@U k
||@@l n
titulo@@o u
==@@v x
$str	@@y î
||
@@ï ó
titulo
@@ò û
==
@@ü °
$str
@@¢ Æ
||
@@Ø ±
titulo
@@≤ ∏
==
@@π ª
$str
@@º ≈
||
@@∆ »
titulo
@@… œ
==
@@– “
$str
@@” €
||
@@‹ ﬁ
titulo
@@ﬂ Â
==
@@Ê Ë
$str
@@È Ò
||
@@Ú Ù
titulo
@@ı ˚
==
@@¸ ˛
$str
@@ˇ á
||
@@à ä
titulo
@@ã ë
==
@@í î
$str
@@ï •
||
@@¶ ®
titulo
@@© Ø
==
@@∞ ≤
$str
@@≥ ≈
)
@@≈ ∆
{AA 
eBB 
.BB 
CancelBB 
=BB 
trueBB 
;BB  
}CC 
ifDD 
(DD 
tituloDD 
==DD 
$strDD "
)DD" #
{EE 
eFF 
.FF 
ColumnFF 
.FF 
DisplayIndexFF %
=FF% &
$numFF& '
;FF' (
}GG 
ifHH 
(HH 
tituloHH 
==HH 
$strHH (
)HH( )
{II 
stringJJ 
numJugadoresJJ #
=JJ$ %

PropertiesJJ& 0
.JJ0 1
	ResourcesJJ1 :
.JJ: ;
numJugadoresJJ; G
;JJG H
eKK 
.KK 
ColumnKK 
.KK 
HeaderKK 
=KK  !
numJugadoresKK" .
;KK. /
eLL 
.LL 
ColumnLL 
.LL 
DisplayIndexLL %
=LL& '
$numLL( )
;LL) *
}MM 
ifNN 
(NN 
tituloNN 
==NN 
$strNN %
)NN% &
{OO 
stringPP 
	dobleDadoPP  
=PP! "

PropertiesPP# -
.PP- .
	ResourcesPP. 7
.PP7 8
	dobleDadoPP8 A
;PPA B
eQQ 
.QQ 
ColumnQQ 
.QQ 
HeaderQQ 
=QQ  !
	dobleDadoQQ" +
;QQ+ ,
eRR 
.RR 
ColumnRR 
.RR 
DisplayIndexRR %
=RR& '
$numRR( )
;RR) *
}SS 
ifTT 
(TT 
tituloTT 
==TT 
$strTT .
)TT. /
{UU 
stringVV 
casillaEspecialVV &
=VV' (

PropertiesVV) 3
.VV3 4
	ResourcesVV4 =
.VV= >
casillaEspecialVV> M
;VVM N
eWW 
.WW 
ColumnWW 
.WW 
HeaderWW 
=WW  !
casillaEspecialWW" 1
;WW1 2
eXX 
.XX 
ColumnXX 
.XX 
DisplayIndexXX %
=XX& '
$numXX( )
;XX) *
}YY 
}ZZ 	
}[[ 
}\\ ÆO
qC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\CrearPartida.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
CrearPartida %
:& '
Window( .
{ 
public 
Jugador 
Jugador 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
CrearPartida 
( 
ServidorJuegoSE +
.+ ,
Jugador, 3
jugadorRecibido4 C
)C D
{ 	
Jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
textBox_Nombre 
. 
Focus  
(  !
)! "
;" #
} 	
private 
void $
TextBox_Nombre_LostFocus -
(- .
object. 4
sender5 ;
,; <
RoutedEventArgs= L
eM N
)N O
{ 	
if 
( 
textBox_Nombre 
. 
Text #
==$ &
$str' )
)) *
{ 
label_Nombre   
.   

Visibility   '
=  ( )

Visibility  * 4
.  4 5
Visible  5 <
;  < =
}!! 
}"" 	
private$$ 
void$$ "
TextBox_Nombre_KeyDown$$ +
($$+ ,
object$$, 2
sender$$3 9
,$$9 :
KeyEventArgs$$; G
e$$H I
)$$I J
{%% 	
label_Nombre&& 
.&& 

Visibility&& #
=&&$ %

Visibility&&& 0
.&&0 1
Hidden&&1 7
;&&7 8
}'' 	
private)) 
void)) "
Label_Nombre_MouseDown)) +
())+ ,
object)), 2
sender))3 9
,))9 : 
MouseButtonEventArgs)); O
e))P Q
)))Q R
{** 	
textBox_Nombre++ 
.++ 
Focus++  
(++  !
)++! "
;++" #
},, 	
private.. 
void.. 
Button_Regresar.. $
(..$ %
object..% +
sender.., 2
,..2 3
RoutedEventArgs..4 C
e..D E
)..E F
{// 	
MenuPrincipal00 
menuPrincipal00 '
=00( )
new00* -
MenuPrincipal00. ;
(00; <
Jugador00< C
)00C D
;00D E
menuPrincipal11 
.11 
Show11 
(11 
)11  
;11  !
this22 
.22 
Close22 
(22 
)22 
;22 
}33 	
private55 
void55 
Button_CrearPartida55 (
(55( )
object55) /
sender550 6
,556 7
RoutedEventArgs558 G
e55H I
)55I J
{66 	
if77 
(77 
!77 
VerificarCampos77  
(77  !
)77! "
)77" #
{88 
return99 
;99 
}:: 
var;; 

rectangulo;; 
=;; 
grid_Fondos;; (
.;;( )
Children;;) 1
.;;1 2
Cast;;2 6
<;;6 7
	UIElement;;7 @
>;;@ A
(;;A B
);;B C
.;;C D
FirstOrDefault;;D R
(;;R S
i;;S T
=>;;U W
i;;X Y
is;;Z \
	Rectangle;;] f
&&;;g i
i;;j k
.;;k l
Opacity;;l s
==;;t v
$num;;w x
);;x y
;;;y z
var<< 
fondo<< 
=<< 
(<< 
Image<< 
)<< 
grid_Fondos<< *
.<<* +
Children<<+ 3
.<<3 4
Cast<<4 8
<<<8 9
	UIElement<<9 B
><<B C
(<<C D
)<<D E
.<<E F
First<<F K
(<<K L
i<<L M
=><<N P
i<<Q R
is<<S U
Image<<V [
&&<<\ ^
Grid<<_ c
.<<c d
	GetColumn<<d m
(<<m n
i<<n o
)<<o p
==<<q s
Grid<<t x
.<<x y
	GetColumn	<<y Ç
(
<<Ç É

rectangulo
<<É ç
)
<<ç é
)
<<é è
;
<<è ê
ServidorJuegoSE== 
.== 
Sala==  
sala==! %
===& '
new==( +
ServidorJuegoSE==, ;
.==; <
Sala==< @
(==@ A
)==A B
{>> 
Nombre?? 
=?? 
textBox_Nombre?? '
.??' (
Text??( ,
,??, -
	DobleDado@@ 
=@@ 
checkBox_DobleDado@@ .
.@@. /
	IsChecked@@/ 8
.@@8 9
Value@@9 >
,@@> ?
CasillasEspecialesAA "
=AA# $'
checkBox_CasillasEspecialesAA% @
.AA@ A
	IsCheckedAAA J
.AAJ K
ValueAAK P
,AAP Q
UriFondoTableroBB 
=BB  !
(BB" #
(BB# $
BitmapFrameBB$ /
)BB/ 0
fondoBB0 5
.BB5 6
SourceBB6 <
)BB< =
.BB= >
DecoderBB> E
.BBE F
ToStringBBF N
(BBN O
)BBO P
}CC 
;CC 
LobbyDD 
lobbyDD 
=DD 
newDD 
LobbyDD #
(DD# $
JugadorDD$ +
)DD+ ,
;DD, -
lobbyEE 
.EE 
CrearPartidaEE 
(EE 
salaEE #
)EE# $
;EE$ %
lobbyFF 
.FF 
ShowFF 
(FF 
)FF 
;FF 
thisGG 
.GG 
CloseGG 
(GG 
)GG 
;GG 
}HH 	
privateJJ 
voidJJ 
Rectangle_ClicJJ #
(JJ# $
objectJJ$ *
senderJJ+ 1
,JJ1 2 
MouseButtonEventArgsJJ3 G
eJJH I
)JJI J
{KK 	
	RectangleLL 

rectanguloLL  
=LL! "
senderLL# )
asLL* ,
	RectangleLL- 6
;LL6 7
varMM "
rectanguloSeleccionadoMM &
=MM' (
grid_FondosMM) 4
.MM4 5
ChildrenMM5 =
.MM= >
CastMM> B
<MMB C
	UIElementMMC L
>MML M
(MMM N
)MMN O
.MMO P
FirstOrDefaultMMP ^
(MM^ _
iMM_ `
=>MMa c
iMMd e
isMMf h
	RectangleMMi r
&&MMs u
iMMv w
.MMw x
OpacityMMx 
==
MMÄ Ç
$num
MMÉ Ñ
)
MMÑ Ö
;
MMÖ Ü
ifNN 
(NN "
rectanguloSeleccionadoNN &
!=NN' )
nullNN* .
)NN. /
{OO "
rectanguloSeleccionadoPP &
.PP& '
OpacityPP' .
=PP/ 0
$numPP1 2
;PP2 3
}QQ 

rectanguloRR 
.RR 
OpacityRR 
=RR  
$numRR! "
;RR" #
}SS 	
privateUU 
boolUU 
VerificarCamposUU $
(UU$ %
)UU% &
{VV 	
ifWW 
(WW 
textBox_NombreWW 
.WW 
TextWW #
.WW# $
EqualsWW$ *
(WW* +
$strWW+ -
)WW- .
)WW. /
{XX 
stringYY 
nombreObligatorioYY (
=YY) *

PropertiesYY+ 5
.YY5 6
	ResourcesYY6 ?
.YY? @
nombreObligatorioYY@ Q
;YYQ R

MessageBoxZZ 
.ZZ 
ShowZZ 
(ZZ  
nombreObligatorioZZ  1
)ZZ1 2
;ZZ2 3
return[[ 
false[[ 
;[[ 
}\\ 
var]] "
rectanguloSeleccionado]] &
=]]' (
grid_Fondos]]) 4
.]]4 5
Children]]5 =
.]]= >
Cast]]> B
<]]B C
	UIElement]]C L
>]]L M
(]]M N
)]]N O
.]]O P
FirstOrDefault]]P ^
(]]^ _
i]]_ `
=>]]a c
i]]d e
is]]f h
	Rectangle]]i r
&&]]s u
i]]v w
.]]w x
Opacity]]x 
==
]]Ä Ç
$num
]]É Ñ
)
]]Ñ Ö
;
]]Ö Ü
if^^ 
(^^ "
rectanguloSeleccionado^^ &
==^^' )
null^^* .
)^^. /
{__ 
string``  
escenarioObligatorio`` +
=``, -

Properties``. 8
.``8 9
	Resources``9 B
.``B C 
escenarioObligatorio``C W
;``W X

MessageBoxaa 
.aa 
Showaa 
(aa   
escenarioObligatorioaa  4
)aa4 5
;aa5 6
returnbb 
falsebb 
;bb 
}cc 
returndd 
truedd 
;dd 
}ee 	
privateff 
voidff 
ValidarTextoff !
(ff! "
objectff" (
senderff) /
,ff/ 0
RoutedEventArgsff1 @
effA B
)ffB C
{gg 	
varhh 
textboxhh 
=hh 
senderhh  
ashh! #
TextBoxhh$ +
;hh+ ,
ifii 
(ii 
textboxii 
.ii 
Textii 
==ii 
$strii  "
)ii" #
{ii$ %
returnjj 
;jj 
}kk 
ifll 
(ll 
!ll 
Regexll 
.ll 
IsMatchll 
(ll 
textboxll &
.ll& '
Textll' +
,ll+ ,
$strll- ?
)ll? @
)ll@ A
{llB C

MessageBoxmm 
.mm 
Showmm 
(mm  

Propertiesmm  *
.mm* +
	Resourcesmm+ 4
.mm4 5
camposInvalidosmm5 D
)mmD E
;mmE F
textboxnn 
.nn 
Clearnn 
(nn 
)nn 
;nn  
}oo 
}pp 	
}qq 
}rr …≈
jC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Turno.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
Turno 
:  
Window! '
{ 
private 
Juego 
juego 
; 
private $
ImageAnimationController (
controladorGif) 7
;7 8
private $
ImageAnimationController (
controladorGif2) 8
;8 9
private 
Random 
	aleatorio  
=! "
new# &
Random' -
(- .
). /
;/ 0
private 
int 
numeroDado1 
;  
private 
int 
numeroDado2 
=  !
$num" #
;# $
private 
bool 
cerrar 
= 
false #
;# $
public 
Ficha 
Ficha 
{ 
get  
;  !
set" %
;% &
}' (
public   
Turno   
(   
Juego   
juegoReferencia   *
)  * +
{!! 	
juego"" 
="" 
juegoReferencia"" #
;""# $
InitializeComponent## 
(##  
)##  !
;##! "
}$$ 	
public)) 
void)) 
ElegirFicha)) 
())  
List))  $
<))$ %
ServidorJuegoSE))% 4
.))4 5
Ficha))5 :
>)): ;
fichasEscogidas))< K
)))K L
{** 	
label_Instruccion++ 
.++ 
Content++ %
=++& '
$str++( 9
;++9 :
ColumnDefinition,, 
columna,, $
;,,$ %
String-- 
uri-- 
;-- 
Image.. 
imagenFicha.. 
;.. 
	Rectangle// 

rectangulo//  
;//  !
for00 
(00 
int00 
i00 
=00 
$num00 
;00 
i00 
<=00  
$num00! "
;00" #
i00$ %
++00% '
)00' (
{11 
uri22 
=22 
$str22 7
+228 9
i22: ;
+22< =
$str22> D
;22D E
if33 
(33 
fichasEscogidas33 #
.33# $
Find33$ (
(33( )
x33) *
=>33+ -
x33. /
.33/ 0
UriFicha330 8
.338 9
Equals339 ?
(33? @
uri33@ C
)33C D
)33D E
==33F H
null33I M
)33M N
{44 
columna55 
=55 
new55 !
ColumnDefinition55" 2
(552 3
)553 4
;554 5
columna66 
.66 
Width66 !
=66" #
new66$ '

GridLength66( 2
(662 3
$num663 6
)666 7
;667 8
grid_Fichas77 
.77  
ColumnDefinitions77  1
.771 2
Add772 5
(775 6
columna776 =
)77= >
;77> ?
imagenFicha88 
=88  !
new88" %
Image88& +
(88+ ,
)88, -
;88- .
imagenFicha99 
.99  
Source99  &
=99' (
new99) ,
BitmapImage99- 8
(998 9
new999 <
Uri99= @
(99@ A
uri99A D
,99D E
UriKind99F M
.99M N
Relative99N V
)99V W
)99W X
;99X Y
imagenFicha:: 
.::  
Name::  $
=::% &
$str::' .
+::. /
i::/ 0
;::0 1

rectangulo;; 
=;;  
new;;! $
	Rectangle;;% .
(;;. /
);;/ 0
;;;0 1

rectangulo<< 
.<< 
Stretch<< &
=<<' (
Stretch<<) 0
.<<0 1
Fill<<1 5
;<<5 6

rectangulo== 
.== 
Stroke== %
===& '
new==( +
SolidColorBrush==, ;
(==; <
Colors==< B
.==B C
Azure==C H
)==H I
;==I J

rectangulo>> 
.>> 
StrokeThickness>> .
=>>/ 0
$num>>1 2
;>>2 3

rectangulo?? 
.?? 
Opacity?? &
=??' (
$num??) *
;??* +

rectangulo@@ 
.@@ 
Fill@@ #
=@@$ %
new@@& )
SolidColorBrush@@* 9
(@@9 :
Colors@@: @
.@@@ A
Transparent@@A L
)@@L M
;@@M N

rectanguloAA 
.AA 
	MouseDownAA (
+=AA) +
Rectangle_ClicAA, :
;AA: ;
GridBB 
.BB 
	SetColumnBB "
(BB" #
imagenFichaBB# .
,BB. /
iBB0 1
-BB2 3
$numBB4 5
)BB5 6
;BB6 7
GridCC 
.CC 
	SetColumnCC "
(CC" #

rectanguloCC# -
,CC- .
iCC/ 0
-CC1 2
$numCC3 4
)CC4 5
;CC5 6
grid_FichasDD 
.DD  
ChildrenDD  (
.DD( )
AddDD) ,
(DD, -
imagenFichaDD- 8
)DD8 9
;DD9 :
grid_FichasEE 
.EE  
ChildrenEE  (
.EE( )
AddEE) ,
(EE, -

rectanguloEE- 7
)EE7 8
;EE8 9
}FF 
}GG 
scrollViewer_FichasHH 
.HH  

VisibilityHH  *
=HH+ ,

VisibilityHH- 7
.HH7 8
VisibleHH8 ?
;HH? @
button_ElegirII 
.II 

VisibilityII $
=II% &

VisibilityII' 1
.II1 2
VisibleII2 9
;II9 :
button_ElegirJJ 
.JJ 
ContentJJ !
=JJ" #
$strJJ$ ,
;JJ, -
}KK 	
privateMM 
voidMM 
Rectangle_ClicMM #
(MM# $
objectMM$ *
senderMM+ 1
,MM1 2 
MouseButtonEventArgsMM3 G
eMMH I
)MMI J
{NN 	
	RectangleOO 

rectanguloOO  
=OO! "
senderOO# )
asOO* ,
	RectangleOO- 6
;OO6 7
varPP "
rectanguloSeleccionadoPP &
=PP' (
grid_FichasPP) 4
.PP4 5
ChildrenPP5 =
.PP= >
CastPP> B
<PPB C
	UIElementPPC L
>PPL M
(PPM N
)PPN O
.PPO P
FirstOrDefaultPPP ^
(PP^ _
iPP_ `
=>PPa c
iPPd e
isPPf h
	RectanglePPi r
&&PPs u
iPPv w
.PPw x
OpacityPPx 
==
PPÄ Ç
$num
PPÉ Ñ
)
PPÑ Ö
;
PPÖ Ü
ifQQ 
(QQ "
rectanguloSeleccionadoQQ &
!=QQ' )
nullQQ* .
)QQ. /
{RR "
rectanguloSeleccionadoSS &
.SS& '
OpacitySS' .
=SS/ 0
$numSS1 2
;SS2 3
}TT 

rectanguloUU 
.UU 
OpacityUU 
=UU  
$numUU! "
;UU" #
}VV 	
privateXX 
voidXX 
Button_ElegirXX "
(XX" #
objectXX# )
senderXX* 0
,XX0 1
RoutedEventArgsXX2 A
eXXB C
)XXC D
{YY 	
varZZ 

rectanguloZZ 
=ZZ 
grid_FichasZZ (
.ZZ( )
ChildrenZZ) 1
.ZZ1 2
CastZZ2 6
<ZZ6 7
	UIElementZZ7 @
>ZZ@ A
(ZZA B
)ZZB C
.ZZC D
FirstOrDefaultZZD R
(ZZR S
iZZS T
=>ZZU W
iZZX Y
isZZZ \
	RectangleZZ] f
&&ZZg i
iZZj k
.ZZk l
OpacityZZl s
==ZZt v
$numZZw x
)ZZx y
;ZZy z
if[[ 
([[ 

rectangulo[[ 
==[[ 
null[[ "
)[[" #
{\\ 

MessageBox]] 
.]] 
Show]] 
(]]  
$str]]  7
)]]7 8
;]]8 9
return^^ 
;^^ 
}__ 
var`` 
direccionFicha`` 
=``  
(``! "
Image``" '
)``' (
grid_Fichas``( 3
.``3 4
Children``4 <
.``< =
Cast``= A
<``A B
	UIElement``B K
>``K L
(``L M
)``M N
.``N O
First``O T
(``T U
i``U V
=>``W Y
i``Z [
is``\ ^
Image``_ d
&&``e g
Grid``h l
.``l m
	GetColumn``m v
(``v w
i``w x
)``x y
==``z |
Grid	``} Å
.
``Å Ç
	GetColumn
``Ç ã
(
``ã å

rectangulo
``å ñ
)
``ñ ó
)
``ó ò
;
``ò ô
Fichaaa 
=aa 
newaa 
ServidorJuegoSEaa '
.aa' (
Fichaaa( -
(aa- .
)aa. /
{aa0 1
NombreFichabb 
=bb 
direccionFichabb ,
.bb, -
Namebb- 1
,bb1 2
UriFichacc 
=cc 
(cc 
(cc 
BitmapImagecc (
)cc( )
direccionFichacc) 7
.cc7 8
Sourcecc8 >
)cc> ?
.cc? @
	UriSourcecc@ I
.ccI J
OriginalStringccJ X
,ccX Y
ApodoJugadordd 
=dd 
juegodd $
.dd$ %
Jugadordd% ,
.dd, -
Apododd- 2
,dd2 3
Posicionee 
=ee 
$numee 
,ee 
Movimientosff 
=ff 
$numff 
,ff  
}hh 
;hh 
cerrarii 
=ii 
trueii 
;ii 
thisjj 
.jj 
Closejj 
(jj 
)jj 
;jj 
juegokk 
.kk 
ClienteMultijugadorkk %
.kk% &
AsignarFichakk& 2
(kk2 3
juegokk3 8
.kk8 9
Salakk9 =
.kk= >
IdSalakk> D
,kkD E
FichakkF K
)kkK L
;kkL M
}ll 	
publicpp 
voidpp 
Tirarpp 
(pp 
)pp 
{qq 	
label_Instruccionrr 
.rr 
Contentrr %
=rr& '
$strrr( 7
;rr7 8
button_Tirarss 
.ss 
Contentss  
=ss! "
$strss# *
;ss* +

grid_Dadostt 
.tt 

Visibilitytt !
=tt" #

Visibilitytt$ .
.tt. /
Visiblett/ 6
;tt6 7
ifuu 
(uu 
juegouu 
.uu 
Salauu 
.uu 
	DobleDadouu $
)uu$ %
{vv 
MostrarDadosww 
(ww 
$numww 
)ww 
;ww  
image_Dado2xx 
.xx 

Visibilityxx &
=xx' (

Visibilityxx) 3
.xx3 4
Visiblexx4 ;
;xx; <
}yy 
elsezz 
{{{ 
MostrarDados|| 
(|| 
$num|| 
)|| 
;||  
}}} 

image_Dado~~ 
.~~ 

Visibility~~ !
=~~" #

Visibility~~$ .
.~~. /
Visible~~/ 6
;~~6 7
} 	
private
ÅÅ 
void
ÅÅ 
Button_Tirar
ÅÅ !
(
ÅÅ! "
object
ÅÅ" (
sender
ÅÅ) /
,
ÅÅ/ 0
RoutedEventArgs
ÅÅ1 @
e
ÅÅA B
)
ÅÅB C
{
ÇÇ 	
button_Tirar
ÉÉ 
.
ÉÉ 

Visibility
ÉÉ #
=
ÉÉ$ %

Visibility
ÉÉ& 0
.
ÉÉ0 1
Hidden
ÉÉ1 7
;
ÉÉ7 8
numeroDado1
ÑÑ 
=
ÑÑ 
	aleatorio
ÑÑ #
.
ÑÑ# $
Next
ÑÑ$ (
(
ÑÑ( )
$num
ÑÑ) *
,
ÑÑ* +
$num
ÑÑ, -
)
ÑÑ- .
;
ÑÑ. /
if
ÖÖ 
(
ÖÖ 
juego
ÖÖ 
.
ÖÖ 
Sala
ÖÖ 
.
ÖÖ 
	DobleDado
ÖÖ $
)
ÖÖ$ %
{
ÜÜ 
numeroDado2
áá 
=
áá 
	aleatorio
áá '
.
áá' (
Next
áá( ,
(
áá, -
$num
áá- .
,
áá. /
$num
áá0 1
)
áá1 2
;
áá2 3
controladorGif2
àà 
.
àà  
Play
àà  $
(
àà$ %
)
àà% &
;
àà& '
}
ââ 
controladorGif
ää 
.
ää 
Play
ää 
(
ää  
)
ää  !
;
ää! "
}
ãã 	
private
çç 
void
çç 
gif_Cargado
çç  
(
çç  !
object
çç! '
sender
çç( .
,
çç. /
RoutedEventArgs
çç0 ?
e
çç@ A
)
ççA B
{
éé 	
controladorGif
èè 
=
èè 
ImageBehavior
èè *
.
èè* +$
GetAnimationController
èè+ A
(
èèA B

image_Dado
èèB L
)
èèL M
;
èèM N
button_Tirar
êê 
.
êê 

Visibility
êê #
=
êê$ %

Visibility
êê& 0
.
êê0 1
Visible
êê1 8
;
êê8 9
}
ëë 	
private
ìì 
void
ìì 
gif2_Cargado
ìì !
(
ìì! "
object
ìì" (
sender
ìì) /
,
ìì/ 0
RoutedEventArgs
ìì1 @
e
ììA B
)
ììB C
{
îî 	
controladorGif2
ïï 
=
ïï 
ImageBehavior
ïï +
.
ïï+ ,$
GetAnimationController
ïï, B
(
ïïB C
image_Dado2
ïïC N
)
ïïN O
;
ïïO P
}
ññ 	
private
òò 
void
òò 
gif_Terminado
òò "
(
òò" #
object
òò# )
sender
òò* 0
,
òò0 1
RoutedEventArgs
òò2 A
e
òòB C
)
òòC D
{
ôô 	

image_Dado
öö 
.
öö 

Visibility
öö !
=
öö" #

Visibility
öö$ .
.
öö. /
	Collapsed
öö/ 8
;
öö8 9
Image
õõ 
caraDado
õõ 
=
õõ 
new
õõ  
Image
õõ! &
(
õõ& '
)
õõ' (
;
õõ( )
String
úú 
uri
úú 
=
úú 
$str
úú 7
+
úú8 9
numeroDado1
úú: E
+
úúF G
$str
úúH N
;
úúN O
caraDado
ùù 
.
ùù 
Source
ùù 
=
ùù 
new
ùù !
BitmapImage
ùù" -
(
ùù- .
new
ùù. 1
Uri
ùù2 5
(
ùù5 6
uri
ùù6 9
,
ùù9 :
UriKind
ùù; B
.
ùùB C
Relative
ùùC K
)
ùùK L
)
ùùL M
;
ùùM N
Grid
ûû 
.
ûû 
	SetColumn
ûû 
(
ûû 
caraDado
ûû #
,
ûû# $
$num
ûû% &
)
ûû& '
;
ûû' (

grid_Dados
üü 
.
üü 
Children
üü 
.
üü  
Add
üü  #
(
üü# $
caraDado
üü$ ,
)
üü, -
;
üü- .
DispatcherTimer
†† 
temporizador
†† (
=
††) *
new
††+ .
DispatcherTimer
††/ >
(
††> ?
)
††? @
;
††@ A
temporizador
°° 
.
°° 
Interval
°° !
=
°°" #
TimeSpan
°°$ ,
.
°°, -
FromSeconds
°°- 8
(
°°8 9
$num
°°9 ;
)
°°; <
;
°°< =
temporizador
¢¢ 
.
¢¢ 
Tick
¢¢ 
+=
¢¢  "
temporizadorDetenido
¢¢! 5
;
¢¢5 6
temporizador
££ 
.
££ 
Start
££ 
(
££ 
)
££  
;
££  !
}
§§ 	
private
¶¶ 
void
¶¶ 
gif2_Terminado
¶¶ #
(
¶¶# $
object
¶¶$ *
sender
¶¶+ 1
,
¶¶1 2
RoutedEventArgs
¶¶3 B
e
¶¶C D
)
¶¶D E
{
ßß 	
image_Dado2
®® 
.
®® 

Visibility
®® "
=
®®# $

Visibility
®®% /
.
®®/ 0
	Collapsed
®®0 9
;
®®9 :
Image
©© 
caraDado
©© 
=
©© 
new
©©  
Image
©©! &
(
©©& '
)
©©' (
;
©©( )
String
™™ 
uri
™™ 
=
™™ 
$str
™™ 7
+
™™8 9
numeroDado2
™™: E
+
™™F G
$str
™™H N
;
™™N O
caraDado
´´ 
.
´´ 
Source
´´ 
=
´´ 
new
´´ !
BitmapImage
´´" -
(
´´- .
new
´´. 1
Uri
´´2 5
(
´´5 6
uri
´´6 9
,
´´9 :
UriKind
´´; B
.
´´B C
Relative
´´C K
)
´´K L
)
´´L M
;
´´M N
Grid
¨¨ 
.
¨¨ 
	SetColumn
¨¨ 
(
¨¨ 
caraDado
¨¨ #
,
¨¨# $
$num
¨¨% &
)
¨¨& '
;
¨¨' (

grid_Dados
≠≠ 
.
≠≠ 
Children
≠≠ 
.
≠≠  
Add
≠≠  #
(
≠≠# $
caraDado
≠≠$ ,
)
≠≠, -
;
≠≠- .
}
ÆÆ 	
private
∞∞ 
void
∞∞ "
temporizadorDetenido
∞∞ )
(
∞∞) *
object
∞∞* 0
sender
∞∞1 7
,
∞∞7 8
	EventArgs
∞∞9 B
e
∞∞C D
)
∞∞D E
{
±± 	
var
≤≤ 
temporizador
≤≤ 
=
≤≤ 
sender
≤≤ %
as
≤≤& (
DispatcherTimer
≤≤) 8
;
≤≤8 9
temporizador
≥≥ 
.
≥≥ 
Stop
≥≥ 
(
≥≥ 
)
≥≥ 
;
≥≥  
cerrar
¥¥ 
=
¥¥ 
true
¥¥ 
;
¥¥ 
this
µµ 
.
µµ 
Close
µµ 
(
µµ 
)
µµ 
;
µµ 
juego
∂∂ 
.
∂∂ !
ClienteMultijugador
∂∂ %
.
∂∂% &
RecibirTiro
∂∂& 1
(
∂∂1 2
juego
∂∂2 7
.
∂∂7 8
Sala
∂∂8 <
.
∂∂< =
IdSala
∂∂= C
,
∂∂C D
numeroDado1
∂∂E P
+
∂∂Q R
numeroDado2
∂∂S ^
)
∂∂^ _
;
∂∂_ `
}
∑∑ 	
private
ππ 
void
ππ 
MostrarDados
ππ !
(
ππ! "
int
ππ" %
numDados
ππ& .
)
ππ. /
{
∫∫ 	
ColumnDefinition
ªª 
columna
ªª $
;
ªª$ %
for
ºº 
(
ºº 
int
ºº 
i
ºº 
=
ºº 
$num
ºº 
;
ºº 
i
ºº 
<
ºº 
numDados
ºº  (
;
ºº( )
i
ºº* +
++
ºº+ -
)
ºº- .
{
ΩΩ 
var
ææ 
gifDado
ææ 
=
ææ 
new
ææ !
BitmapImage
ææ" -
(
ææ- .
)
ææ. /
;
ææ/ 0
gifDado
øø 
.
øø 
	BeginInit
øø !
(
øø! "
)
øø" #
;
øø# $
gifDado
¿¿ 
.
¿¿ 
	UriSource
¿¿ !
=
¿¿" #
new
¿¿$ '
Uri
¿¿( +
(
¿¿+ ,
$str
¿¿, N
,
¿¿N O
UriKind
¿¿P W
.
¿¿W X
Relative
¿¿X `
)
¿¿` a
;
¿¿a b
gifDado
¡¡ 
.
¡¡ 
EndInit
¡¡ 
(
¡¡  
)
¡¡  !
;
¡¡! "
columna
¬¬ 
=
¬¬ 
new
¬¬ 
ColumnDefinition
¬¬ .
(
¬¬. /
)
¬¬/ 0
;
¬¬0 1
columna
√√ 
.
√√ 
Width
√√ 
=
√√ 
new
√√  #

GridLength
√√$ .
(
√√. /
$num
√√/ 2
)
√√2 3
;
√√3 4

grid_Dados
ƒƒ 
.
ƒƒ 
ColumnDefinitions
ƒƒ ,
.
ƒƒ, -
Add
ƒƒ- 0
(
ƒƒ0 1
columna
ƒƒ1 8
)
ƒƒ8 9
;
ƒƒ9 :
if
≈≈ 
(
≈≈ 
i
≈≈ 
==
≈≈ 
$num
≈≈ 
)
≈≈ 
{
∆∆ 
ImageBehavior
«« !
.
««! "
SetAnimatedSource
««" 3
(
««3 4

image_Dado
««4 >
,
««> ?
gifDado
««@ G
)
««G H
;
««H I
Grid
»» 
.
»» 
	SetColumn
»» "
(
»»" #

image_Dado
»»# -
,
»»- .
i
»»/ 0
)
»»0 1
;
»»1 2
}
…… 
else
   
{
ÀÀ 
ImageBehavior
ÃÃ !
.
ÃÃ! "
SetAnimatedSource
ÃÃ" 3
(
ÃÃ3 4
image_Dado2
ÃÃ4 ?
,
ÃÃ? @
gifDado
ÃÃA H
)
ÃÃH I
;
ÃÃI J
Grid
ÕÕ 
.
ÕÕ 
	SetColumn
ÕÕ "
(
ÕÕ" #

image_Dado
ÕÕ# -
,
ÕÕ- .
i
ÕÕ/ 0
)
ÕÕ0 1
;
ÕÕ1 2
}
ŒŒ 
}
œœ 
}
–– 	
public
’’ 
void
’’ 
MostrarGanador
’’ "
(
’’" #
ServidorJuegoSE
’’# 2
.
’’2 3
Ficha
’’3 8
fichaGanador
’’9 E
)
’’E F
{
÷÷ 	
label_Instruccion
◊◊ 
.
◊◊ 
Content
◊◊ %
=
◊◊& '
$str
◊◊( 9
+
◊◊: ;
fichaGanador
◊◊< H
.
◊◊H I
ApodoJugador
◊◊I U
;
◊◊U V
ColumnDefinition
ÿÿ 
columna
ÿÿ $
=
ÿÿ% &
new
ÿÿ' *
ColumnDefinition
ÿÿ+ ;
(
ÿÿ; <
)
ÿÿ< =
;
ÿÿ= >
columna
ŸŸ 
.
ŸŸ 
Width
ŸŸ 
=
ŸŸ 
new
ŸŸ 

GridLength
ŸŸ  *
(
ŸŸ* +
$num
ŸŸ+ .
)
ŸŸ. /
;
ŸŸ/ 0

grid_Dados
⁄⁄ 
.
⁄⁄ 
ColumnDefinitions
⁄⁄ (
.
⁄⁄( )
Add
⁄⁄) ,
(
⁄⁄, -
columna
⁄⁄- 4
)
⁄⁄4 5
;
⁄⁄5 6
Image
€€ 
imagenGanador
€€ 
=
€€  !
new
€€" %
Image
€€& +
(
€€+ ,
)
€€, -
;
€€- .
imagenGanador
‹‹ 
.
‹‹ 
Source
‹‹  
=
‹‹! "
new
‹‹# &
BitmapImage
‹‹' 2
(
‹‹2 3
new
‹‹3 6
Uri
‹‹7 :
(
‹‹: ;
fichaGanador
‹‹; G
.
‹‹G H
UriFicha
‹‹H P
,
‹‹P Q
UriKind
‹‹R Y
.
‹‹Y Z
Relative
‹‹Z b
)
‹‹b c
)
‹‹c d
;
‹‹d e
imagenGanador
›› 
.
›› 
Width
›› 
=
››  !
$num
››" %
;
››% &

grid_Dados
ﬁﬁ 
.
ﬁﬁ 
Children
ﬁﬁ 
.
ﬁﬁ  
Add
ﬁﬁ  #
(
ﬁﬁ# $
imagenGanador
ﬁﬁ$ 1
)
ﬁﬁ1 2
;
ﬁﬁ2 3
Grid
ﬂﬂ 
.
ﬂﬂ 
	SetColumn
ﬂﬂ 
(
ﬂﬂ 
imagenGanador
ﬂﬂ (
,
ﬂﬂ( )
$num
ﬂﬂ* +
)
ﬂﬂ+ ,
;
ﬂﬂ, -
Grid
‡‡ 
.
‡‡ 
SetRow
‡‡ 
(
‡‡ 
imagenGanador
‡‡ %
,
‡‡% &
$num
‡‡' (
)
‡‡( )
;
‡‡) *
button_Salir
·· 
.
·· 
Content
··  
=
··! "
$str
··# *
;
··* +
button_Salir
‚‚ 
.
‚‚ 

Visibility
‚‚ #
=
‚‚$ %

Visibility
‚‚& 0
.
‚‚0 1
Visible
‚‚1 8
;
‚‚8 9

grid_Dados
„„ 
.
„„ 

Visibility
„„ !
=
„„" #

Visibility
„„$ .
.
„„. /
Visible
„„/ 6
;
„„6 7
}
‰‰ 	
private
ÊÊ 
void
ÊÊ 
Cerrando
ÊÊ 
(
ÊÊ 
object
ÊÊ $
sender
ÊÊ% +
,
ÊÊ+ ,
System
ÊÊ- 3
.
ÊÊ3 4
ComponentModel
ÊÊ4 B
.
ÊÊB C
CancelEventArgs
ÊÊC R
e
ÊÊS T
)
ÊÊT U
{
ÁÁ 	
if
ËË 
(
ËË 
!
ËË 
cerrar
ËË 
)
ËË 
{
ÈÈ 
e
ÍÍ 
.
ÍÍ 
Cancel
ÍÍ 
=
ÍÍ 
true
ÍÍ 
;
ÍÍ  
}
ÎÎ 
}
ÏÏ 	
private
ÓÓ 
void
ÓÓ 
Button_Salir
ÓÓ !
(
ÓÓ! "
object
ÓÓ" (
sender
ÓÓ) /
,
ÓÓ/ 0
RoutedEventArgs
ÓÓ1 @
e
ÓÓA B
)
ÓÓB C
{
ÔÔ 	
cerrar
 
=
 
true
 
;
 
MenuPrincipal
ÒÒ 
menuPrincipal
ÒÒ '
=
ÒÒ( )
new
ÒÒ* -
MenuPrincipal
ÒÒ. ;
(
ÒÒ; <
juego
ÒÒ< A
.
ÒÒA B
Jugador
ÒÒB I
)
ÒÒI J
;
ÒÒJ K
menuPrincipal
ÚÚ 
.
ÚÚ 
Show
ÚÚ 
(
ÚÚ 
)
ÚÚ  
;
ÚÚ  !
this
ÛÛ 
.
ÛÛ 
Close
ÛÛ 
(
ÛÛ 
)
ÛÛ 
;
ÛÛ 
}
ÙÙ 	
}
ıı 
}ˆˆ ú
hC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\App.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
App 
: 
Application *
{+ ,
App		 
(		 
)		 
{		 
} 	
} 
} ºr
oC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\MainWindow.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 

MainWindow #
:$ %
Window& ,
{ 
const 
string 
ERRORBD 
= 
$str 7
;7 8
public 

MainWindow 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
textBox_Usuario 
. 
Focus !
(! "
)" #
;# $
} 	
private"" 
void""  
Button_IniciarSesion"" )
("") *
object""* 0
sender""1 7
,""7 8
RoutedEventArgs""9 H
e""I J
)""J K
{## 	
String$$ 
correoIngresado$$ "
=$$# $
textBox_Usuario$$% 4
.$$4 5
Text$$5 9
;$$9 :
String%%  
contrase√±aIngresada%% &
=%%' (#
passwordBox_contrase√±a%%) ?
.%%? @
Password%%@ H
;%%H I
if&& 
(&& 
!&& 
ValidarCamposVacios&& $
(&&$ %
)&&% &
||&&' )
!&&* + 
ValidarFormatoCorreo&&+ ?
(&&? @
)&&@ A
)&&A B
{'' 
return(( 
;(( 
})) 
ServidorJuegoSE** 
.** %
AdministradorCuentaClient** 5
cliente**6 =
=**> ?
new**@ C
ServidorJuegoSE**D S
.**S T%
AdministradorCuentaClient**T m
(**m n
)**n o
;**o p
ServidorJuegoSE++ 
.++ 
Cuenta++ "
cuenta++# )
=++* +
new++, /
ServidorJuegoSE++0 ?
.++? @
Cuenta++@ F
(++F G
)++G H
{++I J
Correo++K Q
=++R S
correoIngresado++T c
,++c d
Contrase√±a++e o
=++p q!
contrase√±aIngresada	++r Ö
}
++Ü á
;
++á à
ServidorJuegoSE,, 
.,, 
Jugador,, #
jugador,,$ +
;,,+ ,
try-- 
{.. 
jugador// 
=// 
cliente// !
.//! "
IniciarSesion//" /
(/// 0
cuenta//0 6
)//6 7
;//7 8
cuenta00 
=00 
cliente00  
.00  !
VerificarCuenta00! 0
(000 1
cuenta001 7
)007 8
;008 9
}22 
catch33 
(33 
System33 
.33 
ServiceModel33 &
.33& '%
EndpointNotFoundException33' @
)33@ A
{44 

MessageBox55 
.55 
Show55 
(55  

Properties55  *
.55* +
	Resources55+ 4
.554 5!
errorConexionServidor555 J
,55J K

Properties55L V
.55V W
	Resources55W `
.55` a
tituloErrorConexion55a t
,55t u
MessageBoxButton	55v Ü
.
55Ü á
OK
55á â
,
55â ä
MessageBoxImage
55ã ö
.
55ö õ
Error
55õ †
)
55† °
;
55° ¢
return66 
;66 
}77 
if88 
(88 
jugador88 
!=88 
null88 
&&88  "
cuenta88# )
!=88* ,
null88, 0
)880 1
{99 
if:: 
(:: 
cuenta:: 
.:: 
Correo:: !
.::! "
Equals::" (
(::( )
ERRORBD::) 0
)::0 1
||::2 4
jugador::5 <
.::< =
Apodo::= B
.::B C
Equals::C I
(::I J
ERRORBD::J Q
)::Q R
)::R S
{;; 

MessageBox<< 
.<< 
Show<< #
(<<# $

Properties<<$ .
.<<. /
	Resources<</ 8
.<<8 9"
errorConexionBaseDatos<<9 O
,<<O P

Properties<<Q [
.<<[ \
	Resources<<\ e
.<<e f
tituloErrorConexion<<f y
,<<y z
MessageBoxButton	<<{ ã
.
<<ã å
OK
<<å é
,
<<é è
MessageBoxImage
<<ê ü
.
<<ü †
Error
<<† •
)
<<• ¶
;
<<¶ ß
return== 
;== 
}>> 
if?? 
(?? 
cuenta?? 
.?? 
Validada?? #
)??# $
{@@ 
MenuPrincipalAA !
ventanaPrincipalAA" 2
=AA3 4
newAA5 8
MenuPrincipalAA9 F
(AAF G
jugadorAAG N
)AAN O
;AAO P
ventanaPrincipalBB $
.BB$ %
ShowBB% )
(BB) *
)BB* +
;BB+ ,
thisCC 
.CC 
CloseCC 
(CC 
)CC  
;CC  !
}DD 
elseEE 
{FF 
IngresarCodigoGG "!
ventanaIngresarCodigoGG# 8
=GG9 :
newGG; >
IngresarCodigoGG? M
(GGM N
cuentaGGN T
)GGT U
;GGU V!
ventanaIngresarCodigoHH )
.HH) *
ShowHH* .
(HH. /
)HH/ 0
;HH0 1
thisII 
.II 
CloseII 
(II 
)II  
;II  !
}JJ 
}KK 
elseLL 
{MM 

MessageBoxNN 
.NN 
ShowNN 
(NN  

PropertiesNN  *
.NN* +
	ResourcesNN+ 4
.NN4 5'
usuarioContrase√±aInvalidasNN5 O
)NNO P
;NNP Q
}OO 
}PP 	
privateWW 
voidWW 
Button_RegistrarseWW '
(WW' (
objectWW( .
senderWW/ 5
,WW5 6
RoutedEventArgsWW7 F
eWWG H
)WWH I
{XX 	
RegistroUsuarioYY 
ventanaRegistroYY +
=YY, -
newYY. 1
RegistroUsuarioYY2 A
(YYA B
)YYB C
;YYC D
ventanaRegistroZZ 
.ZZ 
ShowZZ  
(ZZ  !
)ZZ! "
;ZZ" #
this[[ 
.[[ 
Close[[ 
([[ 
)[[ 
;[[ 
}\\ 	
privatecc 
voidcc !
CambiarIdiomaEspa√±olcc )
(cc) *
objectcc* 0
sendercc1 7
,cc7 8
RoutedEventArgscc9 H
eccI J
)ccJ K
{dd 	
Systemee 
.ee 
	Threadingee 
.ee 
Threadee #
.ee# $
CurrentThreadee$ 1
.ee1 2
CurrentUICultureee2 B
=eeC D
neweeE H
SystemeeI O
.eeO P
GlobalizationeeP ]
.ee] ^
CultureInfoee^ i
(eei j
$streej l
)eel m
;eem n

MainWindowff 
loginff 
=ff 
newff "

MainWindowff# -
(ff- .
)ff. /
;ff/ 0
logingg 
.gg 
Showgg 
(gg 
)gg 
;gg 
thishh 
.hh 
Closehh 
(hh 
)hh 
;hh 
}ii 	
privatepp 
voidpp 
CambiarIdiomaInglespp (
(pp( )
objectpp) /
senderpp0 6
,pp6 7
RoutedEventArgspp8 G
eppH I
)ppI J
{qq 	
Systemrr 
.rr 
	Threadingrr 
.rr 
Threadrr #
.rr# $
CurrentThreadrr$ 1
.rr1 2
CurrentUICulturerr2 B
=rrC D
newrrE H
SystemrrI O
.rrO P
GlobalizationrrP ]
.rr] ^
CultureInforr^ i
(rri j
$strrrj q
)rrq r
;rrr s

MainWindowss 
loginss 
=ss 
newss "

MainWindowss# -
(ss- .
)ss. /
;ss/ 0
logintt 
.tt 
Showtt 
(tt 
)tt 
;tt 
thisuu 
.uu 
Closeuu 
(uu 
)uu 
;uu 
}vv 	
public|| 
bool|| 
ValidarCamposVacios|| '
(||' (
)||( )
{}} 	
if 
( 
textBox_Usuario 
.  
Text  $
==% '
$str( *
)+ ,
{
ÄÄ 
string
ÅÅ 
ingresaUsuario
ÅÅ %
=
ÅÅ& '

Properties
ÅÅ( 2
.
ÅÅ2 3
	Resources
ÅÅ3 <
.
ÅÅ< =
ingresaUsuario
ÅÅ= K
;
ÅÅK L

MessageBox
ÇÇ 
.
ÇÇ 
Show
ÇÇ 
(
ÇÇ  
ingresaUsuario
ÇÇ  .
)
ÇÇ. /
;
ÇÇ/ 0
return
ÉÉ 
false
ÉÉ 
;
ÉÉ 
}
ÑÑ 
else
ÖÖ 
if
ÖÖ 
(
ÖÖ %
passwordBox_contrase√±a
ÖÖ +
.
ÖÖ+ ,
SecurePassword
ÖÖ, :
.
ÖÖ: ;
Length
ÖÖ; A
==
ÖÖB D
$num
ÖÖE F
)
ÖÖF G
{
ÜÜ 
string
áá  
ingresaContrase√±a
áá (
=
áá) *

Properties
áá+ 5
.
áá5 6
	Resources
áá6 ?
.
áá? @ 
ingresaContrase√±a
áá@ Q
;
ááQ R

MessageBox
àà 
.
àà 
Show
àà 
(
àà   
ingresaContrase√±a
àà  1
)
àà1 2
;
àà2 3
return
ââ 
false
ââ 
;
ââ 
}
ää 
return
ãã 
true
ãã 
;
ãã 
}
åå 	
private
ìì 
void
ìì '
TextBox_Usuario_LostFocus
ìì .
(
ìì. /
object
ìì/ 5
sender
ìì6 <
,
ìì< =
RoutedEventArgs
ìì> M
e
ììN O
)
ììO P
{
îî 	
if
ïï 
(
ïï 
textBox_Usuario
ïï 
.
ïï  
Text
ïï  $
==
ïï% '
$str
ïï( *
)
ïï* +
{
ññ 
label_Usuario
óó 
.
óó 

Visibility
óó (
=
óó) *

Visibility
óó+ 5
.
óó5 6
Visible
óó6 =
;
óó= >
}
òò 
}
ôô 	
private
†† 
void
†† /
!PasswordBox_Contrase√±a_LostFocus
†† 5
(
††5 6
object
††6 <
sender
††= C
,
††C D
RoutedEventArgs
††E T
e
††U V
)
††V W
{
°° 	
if
¢¢ 
(
¢¢ %
passwordBox_contrase√±a
¢¢ &
.
¢¢& '
Password
¢¢' /
==
¢¢0 2
$str
¢¢3 5
)
¢¢5 6
{
££ 
label_Contrase√±a
§§  
.
§§  !

Visibility
§§! +
=
§§, -

Visibility
§§. 8
.
§§8 9
Visible
§§9 @
;
§§@ A
return
•• 
;
•• 
}
¶¶ 
if
ßß 
(
ßß 
!
ßß 
Regex
ßß 
.
ßß 
IsMatch
ßß 
(
ßß %
passwordBox_contrase√±a
ßß 5
.
ßß5 6
Password
ßß6 >
,
ßß> ?
$str
ßß@ H
)
ßßH I
)
ßßI J
{
®® 

MessageBox
©© 
.
©© 
Show
©© 
(
©©  

Properties
©©  *
.
©©* +
	Resources
©©+ 4
.
©©4 5
camposInvalidos
©©5 D
)
©©D E
;
©©E F%
passwordBox_contrase√±a
™™ &
.
™™& '
Clear
™™' ,
(
™™, -
)
™™- .
;
™™. /
}
´´ 
}
¨¨ 	
private
≥≥ 
void
≥≥ !
PasswordBox_KeyDown
≥≥ (
(
≥≥( )
object
≥≥) /
sender
≥≥0 6
,
≥≥6 7
KeyEventArgs
≥≥8 D
e
≥≥E F
)
≥≥F G
{
¥¥ 	
label_Contrase√±a
µµ 
.
µµ 

Visibility
µµ '
=
µµ( )

Visibility
µµ* 4
.
µµ4 5
Hidden
µµ5 ;
;
µµ; <
}
∂∂ 	
private
ΩΩ 
void
ΩΩ %
TextBox_Usuario_KeyDown
ΩΩ ,
(
ΩΩ, -
object
ΩΩ- 3
sender
ΩΩ4 :
,
ΩΩ: ;
KeyEventArgs
ΩΩ< H
e
ΩΩI J
)
ΩΩJ K
{
ææ 	
label_Usuario
øø 
.
øø 

Visibility
øø $
=
øø% &

Visibility
øø' 1
.
øø1 2
Hidden
øø2 8
;
øø8 9
}
¿¿ 	
private
«« 
void
«« )
Label_Contrase√±a_MouseDown
«« /
(
««/ 0
object
««0 6
sender
««7 =
,
««= >"
MouseButtonEventArgs
««? S
e
««T U
)
««U V
{
»» 	%
passwordBox_contrase√±a
…… "
.
……" #
Focus
……# (
(
……( )
)
……) *
;
……* +
}
   	
private
—— 
void
—— %
Label_Usuario_MouseDown
—— ,
(
——, -
object
——- 3
sender
——4 :
,
——: ;"
MouseButtonEventArgs
——< P
e
——Q R
)
——R S
{
““ 	
textBox_Usuario
”” 
.
”” 
Focus
”” !
(
””! "
)
””" #
;
””# $
}
‘‘ 	
private
⁄⁄ 
Boolean
⁄⁄ "
ValidarFormatoCorreo
⁄⁄ ,
(
⁄⁄, -
)
⁄⁄- .
{
€€ 	
String
‹‹ 
	expresion
‹‹ 
=
‹‹ 
$str
‹‹ T
;
‹‹T U
if
›› 
(
›› 
Regex
›› 
.
›› 
IsMatch
›› 
(
›› 
textBox_Usuario
›› -
.
››- .
Text
››. 2
,
››2 3
	expresion
››4 =
)
››= >
&&
››? A
Regex
››B G
.
››G H
Replace
››H O
(
››O P
textBox_Usuario
››P _
.
››_ `
Text
››` d
,
››d e
	expresion
››f o
,
››o p
String
››q w
.
››w x
Empty
››x }
)
››} ~
.
››~ 
Length›› Ö
==››Ü à
$num››â ä
)››ä ã
{
ﬁﬁ 
return
ﬂﬂ 
true
ﬂﬂ 
;
ﬂﬂ 
}
‡‡ 

MessageBox
·· 
.
·· 
Show
·· 
(
·· 

Properties
·· &
.
··& '
	Resources
··' 0
.
··0 1
correoInvalido
··1 ?
)
··? @
;
··@ A
return
‚‚ 
false
‚‚ 
;
‚‚ 
}
„„ 	
}
ÁÁ 
}ËË æ
wC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str .
). /
]/ 0
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str $
)$ %
]% &
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 7
)7 8
]8 9
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[   
assembly   	
:  	 

	ThemeInfo   
(   &
ResourceDictionaryLocation!! 
.!! 
None!! #
,!!# $&
ResourceDictionaryLocation$$ 
.$$ 
SourceAssembly$$ -
)'' 
]'' 
[44 
assembly44 	
:44	 

AssemblyVersion44 
(44 
$str44 $
)44$ %
]44% &
[55 
assembly55 	
:55	 

AssemblyFileVersion55 
(55 
$str55 (
)55( )
]55) *