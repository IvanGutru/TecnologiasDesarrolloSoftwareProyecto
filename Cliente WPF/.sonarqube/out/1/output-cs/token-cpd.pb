�
gC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Casilla.cs
	namespace 	
SerpientesEscaleras
 
{ 
} �Z
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
{ 
private		 
Lobby		 
lobby		 
;		 
private

 
Juego

 
juego

 
;

 
public 
Juego 
Juego 
{ 
get  
=>! #
juego$ )
;) *
set+ .
=>/ 1
juego2 7
=8 9
value: ?
;? @
}A B
public 
Lobby 
Lobby 
{ 
get  
=>! #
lobby$ )
;) *
set+ .
=>/ 1
lobby2 7
=8 9
value: ?
;? @
}A B
public 
void 
RecibirMensajeLobby '
(' (
string( .
mensaje/ 6
)6 7
{ 	
lobby 
. 
chat 
. 
Add 
( 
mensaje "
)" #
;# $
lobby 
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
public 
void &
RecibirMensajeMiembroLobby .
(. /
Boolean/ 6
entrada7 >
,> ?
String@ F
apodoG L
)L M
{ 	
if 
( 
entrada 
) 
{ 
lobby 
. 
chat 
. 
Add 
( 
apodo $
+% &
$str' *
++ ,

Properties- 7
.7 8
	Resources8 A
.A B
mensajeEntradaB P
)P Q
;Q R
lobby 
. 
jugadoresConectados )
.) *
Add* -
(- .
apodo. 3
)3 4
;4 5
lobby 
. %
label_JugadoresConectados /
./ 0
Content0 7
=8 9
lobby: ?
.? @
jugadoresConectados@ S
.S T
CountT Y
+Z [

Properties\ f
.f g
	Resourcesg p
.p q 
jugadoresConectados	q �
;
� �
} 
else 
{ 
lobby   
.   
chat   
.   
Add   
(   
apodo   $
+  % &
$str  ' *
+  + ,

Properties  - 7
.  7 8
	Resources  8 A
.  A B
mensajeSalida  B O
)  O P
;  P Q
lobby!! 
.!! 
jugadoresConectados!! )
.!!) *
Remove!!* 0
(!!0 1
apodo!!1 6
)!!6 7
;!!7 8
lobby"" 
."" %
label_JugadoresConectados"" /
.""/ 0
Content""0 7
=""8 9
lobby"": ?
.""? @
jugadoresConectados""@ S
.""S T
Count""T Y
+""Z [

Properties""\ f
.""f g
	Resources""g p
.""p q 
jugadoresConectados	""q �
;
""� �
}## 
lobby$$ 
.$$ 
listBox_Chat$$ 
.$$ 
Items$$ $
.$$$ %
Refresh$$% ,
($$, -
)$$- .
;$$. /
lobby%% 
.%% '
listBox_JugadoresConectados%% -
.%%- .
Items%%. 3
.%%3 4
Refresh%%4 ;
(%%; <
)%%< =
;%%= >
}&& 	
public(( 
void(( 
EntrarJuego(( 
(((  
ServidorJuegoSE((  /
.((/ 0
Casilla((0 7
[((7 8
]((8 9
casillas((: B
,((B C
ServidorJuegoSE((D S
.((S T
Portal((T Z
[((Z [
](([ \
portales((] e
)((e f
{)) 	
lobby** 
.** 
EntrarJuego** 
(** 
casillas** &
,**& '
portales**( 0
)**0 1
;**1 2
}++ 	
public-- 
void-- 
RecibirMensaje-- "
(--" #
string--# )
mensaje--* 1
)--1 2
{.. 	
juego// 
.// 
chat// 
.// 
Add// 
(// 
mensaje// "
)//" #
;//# $
juego00 
.00 
listBox_Chat00 
.00 
Items00 $
.00$ %
Refresh00% ,
(00, -
)00- .
;00. /
}11 	
public33 
void33 !
RecibirMensajeMiembro33 )
(33) *
Boolean33* 1
entrada332 9
,339 :
String33; A
apodo33B G
)33G H
{44 	
if55 
(55 
entrada55 
)55 
{66 
int77 
indiceApodo77 
=77  !
juego77" '
.77' (
jugadoresConectados77( ;
.77; <
	FindIndex77< E
(77E F
x77F G
=>77H J
x77K L
.77L M
Contains77M U
(77U V
apodo77V [
)77[ \
)77\ ]
;77] ^
if88 
(88 
indiceApodo88 
!=88  "
-88# $
$num88$ %
)88% &
{99 
return:: 
;:: 
};; 
juego<< 
.<< 
chat<< 
.<< 
Add<< 
(<< 
apodo<< $
+<<% &
$str<<' *
+<<+ ,

Properties<<- 7
.<<7 8
	Resources<<8 A
.<<A B
mensajeEntrada<<B P
)<<P Q
;<<Q R
juego== 
.== 
jugadoresConectados== )
.==) *
Add==* -
(==- .
apodo==. 3
)==3 4
;==4 5
}>> 
else?? 
{@@ 
juegoAA 
.AA 
chatAA 
.AA 
AddAA 
(AA 
apodoAA $
+AA% &
$strAA' *
+AA+ ,

PropertiesAA- 7
.AA7 8
	ResourcesAA8 A
.AAA B
mensajeSalidaAAB O
)AAO P
;AAP Q
juegoBB 
.BB 
jugadoresConectadosBB )
.BB) *
RemoveBB* 0
(BB0 1
apodoBB1 6
)BB6 7
;BB7 8
}CC 
juegoDD 
.DD 
listBox_ChatDD 
.DD 
ItemsDD $
.DD$ %
RefreshDD% ,
(DD, -
)DD- .
;DD. /
juegoEE 
.EE '
listBox_JugadoresConectadosEE -
.EE- .
ItemsEE. 3
.EE3 4
RefreshEE4 ;
(EE; <
)EE< =
;EE= >
}FF 	
publicHH 
voidHH !
SolicitarCrearTableroHH )
(HH) *
)HH* +
{II 	
}KK 	
publicMM 
voidMM 
ElegirFichaMM 
(MM  
StringMM  &
apodoMM' ,
,MM, -
ServidorJuegoSEMM. =
.MM= >
FichaMM> C
[MMC D
]MMD E
fichasEscogidasMMF U
)MMU V
{NN 	
TurnoOO 
turnoOO 
=OO 
newOO 
TurnoOO #
(OO# $
juegoOO$ )
)OO) *
;OO* +
juegoPP 
.PP 
label_AvisoPP 
.PP 
ContentPP %
=PP& '
apodoPP( -
+PP. /
$strPP0 M
;PPM N
ifQQ 
(QQ 
apodoQQ 
.QQ 
EqualsQQ 
(QQ 
juegoQQ "
.QQ" #
jugadorQQ# *
.QQ* +
ApodoQQ+ 0
)QQ0 1
)QQ1 2
{RR 
turnoSS 
.SS 
ElegirFichaSS !
(SS! "
fichasEscogidasSS" 1
.SS1 2
ToListSS2 8
(SS8 9
)SS9 :
)SS: ;
;SS; <
turnoTT 
.TT 

ShowDialogTT  
(TT  !
)TT! "
;TT" #
}UU 
}VV 	
publicXX 
voidXX 
MostrarFichaElegidaXX '
(XX' (
ServidorJuegoSEXX( 7
.XX7 8
FichaXX8 =
fichaXX> C
)XXC D
{YY 	
juegoZZ 
.ZZ 
jugadorEnTurnoZZ  
=ZZ! "
fichaZZ# (
;ZZ( )
juego[[ 
.[[ !
MostrarFichaEnTablero[[ '
([[' (
)[[( )
;[[) *
}\\ 	
public^^ 
void^^ 
Tirar^^ 
(^^ 
String^^  
apodo^^! &
)^^& '
{__ 	
Turno`` 
turno`` 
=`` 
new`` 
Turno`` #
(``# $
juego``$ )
)``) *
;``* +
juegoaa 
.aa 
label_Avisoaa 
.aa 
Contentaa %
=aa& '
apodoaa( -
+aa. /
$straa0 B
;aaB C
ifbb 
(bb 
apodobb 
.bb 
Equalsbb 
(bb 
juegobb "
.bb" #
jugadorbb# *
.bb* +
Apodobb+ 0
)bb0 1
)bb1 2
{cc 
turnodd 
.dd 
Tirardd 
(dd 
)dd 
;dd 
turnoee 
.ee 

ShowDialogee  
(ee  !
)ee! "
;ee" #
}ff 
}gg 	
publicii 
voidii 
MostrarTiroii 
(ii  
ServidorJuegoSEii  /
.ii/ 0
Fichaii0 5
fichaii6 ;
)ii; <
{jj 	
juegokk 
.kk 
jugadorEnTurnokk  
=kk! "
fichakk# (
;kk( )
juegoll 
.ll 

MoverFichall 
(ll 
falsell "
)ll" #
;ll# $
}mm 	
publicoo 
voidoo !
MostrarNuevosPortalesoo )
(oo) *
ServidorJuegoSEoo* 9
.oo9 :
Portaloo: @
[oo@ A
]ooA B
portalesooC K
)ooK L
{pp 	
juegoqq 
.qq 
CambiarPortalesqq !
(qq! "
portalesqq" *
)qq* +
;qq+ ,
}rr 	
publictt 
voidtt 
MostrarGanadortt "
(tt" #
ServidorJuegoSEtt# 2
.tt2 3
Fichatt3 8
fichatt9 >
)tt> ?
{uu 	
Turnovv 
turnovv 
=vv 
newvv 
Turnovv #
(vv# $
juegovv$ )
)vv) *
;vv* +
juegoww 
.ww 
label_Avisoww 
.ww 
Contentww %
=ww& '
$strww( *
;ww* +
turnoxx 
.xx 
MostrarGanadorxx  
(xx  !
fichaxx! &
)xx& '
;xx' (
turnoyy 
.yy 

ShowDialogyy 
(yy 
)yy 
;yy 
juegozz 
.zz 
Closezz 
(zz 
)zz 
;zz 
}{{ 	
}|| 
}}} �
fC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Portal.cs
	namespace 	
SerpientesEscaleras
 
{ 
}ll �
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
public 
ConsultarPuntajes  
(  !
ServidorJuegoSE! 0
.0 1
Jugador1 8
jugadorRecibido9 H
)H I
{J K
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
ServidorJuegoSE 
. %
AdministradorCuentaClient 5
cliente6 =
=> ?
new@ C
ServidorJuegoSED S
.S T%
AdministradorCuentaClientT m
(m n
)n o
;o p 
DataGrid_MisPuntajes  
.  !
ItemsSource! ,
=- .
cliente/ 6
.6 7$
ConsultarPuntajesPropios7 O
(O P
jugadorP W
)W X
;X Y$
DataGrid_MejoresPuntajes $
.$ %
ItemsSource% 0
=1 2
cliente3 :
.: ;$
ConsultarMejoresPuntajes; S
(S T
)T U
;U V
} 	
private 
void 
Button_Click !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{D E
MenuPrincipal 
ventanaPrincipal *
=+ ,
new- 0
MenuPrincipal1 >
(> ?
jugador? F
)F G
;G H
ventanaPrincipal 
. 
Show !
(! "
)" #
;# $
this 
. 
Close 
( 
) 
; 
} 	
} 
} �@
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
public

 
IngresarCodigo

 
(

 
ServidorJuegoSE

 .
.

. /
Cuenta

/ 5
cuentaRecibida

6 D
)

D E
{

F G
cuenta 
= 
cuentaRecibida #
;# $
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Salir !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{D E

MainWindow 
vetanaPrincipal &
=' (
new) ,

MainWindow- 7
(7 8
)8 9
;9 :
vetanaPrincipal 
. 
Show  
(  !
)! "
;" #
this 
. 
Close 
( 
) 
; 
} 	
private 
void  
Button_ValidarCuenta )
() *
object* 0
sender1 7
,7 8
RoutedEventArgs9 H
eI J
)J K
{L M
if 
( 
textBox_Codigo 
. 
Text #
==$ &
$str' )
)) *
{+ ,
string 
ingresarCodigo %
=& '

Properties( 2
.2 3
	Resources3 <
.< =$
ingresarCodigoActivacion= U
;U V

MessageBox 
. 
Show 
(  
ingresarCodigo  .
). /
;/ 0
return 
; 
} 
ServidorJuegoSE 
. %
AdministradorCuentaClient 5
cliente6 =
=> ?
new@ C
ServidorJuegoSED S
.S T%
AdministradorCuentaClientT m
(m n
)n o
;o p
try 
{ 
int 
	respuesta 
= 
cliente  '
.' ( 
ActivarCuentaJugador( <
(< =
cuenta= C
,C D
textBox_CodigoE S
.S T
TextT X
)X Y
;Y Z
if 
( 
	respuesta 
==  
$num! "
)" #
{   
var!! 
cuentaActivada!! &
=!!' (

Properties!!) 3
.!!3 4
	Resources!!4 =
.!!= >
cuentaActivada!!> L
;!!L M

MessageBox"" 
."" 
Show"" #
(""# $
cuentaActivada""$ 2
)""2 3
;""3 4

MainWindow## 
vetanaPrincipal## .
=##/ 0
new##1 4

MainWindow##5 ?
(##? @
)##@ A
;##A B
vetanaPrincipal$$ #
.$$# $
Show$$$ (
($$( )
)$$) *
;$$* +
this%% 
.%% 
Close%% 
(%% 
)%%  
;%%  !
}&& 
else'' 
if'' 
('' 
	respuesta'' "
==''# %
$num''& '
)''' (
{(( 

MessageBox)) 
.)) 
Show)) #
())# $

Properties))$ .
.)). /
	Resources))/ 8
.))8 9
codigoInvalido))9 G
)))G H
;))H I
}** 
else++ 
if++ 
(++ 
	respuesta++ "
==++# %
-++& '
$num++' )
||++* ,
	respuesta++- 6
==++7 9
-++: ;
$num++; =
)++= >
{,, 

MessageBox-- 
.-- 
Show-- #
(--# $

Properties--$ .
.--. /
	Resources--/ 8
.--8 9"
errorConexionBaseDatos--9 O
,--O P

Properties--Q [
.--[ \
	Resources--\ e
.--e f
tituloErrorConexion--f y
,--y z
MessageBoxButton	--{ �
.
--� �
OK
--� �
,
--� �
MessageBoxImage
--� �
.
--� �
Error
--� �
)
--� �
;
--� �
}.. 
}// 
catch00 
(00 
System00 
.00 
ServiceModel00 &
.00& '%
EndpointNotFoundException00' @
)00@ A
{11 

MessageBox22 
.22 
Show22 
(22  

Properties22  *
.22* +
	Resources22+ 4
.224 5!
errorConexionServidor225 J
,22J K

Properties22L V
.22V W
	Resources22W `
.22` a
tituloErrorConexion22a t
,22t u
MessageBoxButton	22v �
.
22� �
OK
22� �
,
22� �
MessageBoxImage
22� �
.
22� �
Error
22� �
)
22� �
;
22� �
}33 
}44 	
private66 
void66 !
Button_ReenviarCorreo66 *
(66* +
object66+ 1
sender662 8
,668 9
RoutedEventArgs66: I
e66J K
)66K L
{66M N
ServidorJuegoSE77 
.77 %
AdministradorCuentaClient77 5
cliente776 =
=77> ?
new77@ C
ServidorJuegoSE77D S
.77S T%
AdministradorCuentaClient77T m
(77m n
)77n o
;77o p
int88 
	respuesta88 
;88 
try99 
{:: 
	respuesta;; 
=;; 
cliente;; #
.;;# $
EnviarCorreo;;$ 0
(;;0 1
cuenta;;1 7
);;7 8
;;;8 9
if<< 
(<< 
	respuesta<< 
==<<  
$num<<! "
)<<" #
{== 

MessageBox>> 
.>> 
Show>> #
(>># $

Properties>>$ .
.>>. /
	Resources>>/ 8
.>>8 9
correoEnviado>>9 F
)>>F G
;>>G H
}?? 
if@@ 
(@@ 
	respuesta@@ 
==@@  
-@@! "
$num@@" $
)@@$ %
{AA 

MessageBoxBB 
.BB 
ShowBB #
(BB# $

PropertiesBB$ .
.BB. /
	ResourcesBB/ 8
.BB8 9"
errorConexionBaseDatosBB9 O
,BBO P

PropertiesBBQ [
.BB[ \
	ResourcesBB\ e
.BBe f
tituloErrorConexionBBf y
,BBy z
MessageBoxButton	BB{ �
.
BB� �
OK
BB� �
,
BB� �
MessageBoxImage
BB� �
.
BB� �
Error
BB� �
)
BB� �
;
BB� �
}CC 
ifDD 
(DD 
	respuestaDD 
==DD  
$numDD! "
)DD" #
{EE 

MessageBoxFF 
.FF 
ShowFF #
(FF# $

PropertiesFF$ .
.FF. /
	ResourcesFF/ 8
.FF8 9
errorMandarCorreoFF9 J
)FFJ K
;FFK L
}GG 
}HH 
catchII 
(II 
SystemII 
.II 
ServiceModelII &
.II& '%
EndpointNotFoundExceptionII' @
)II@ A
{JJ 

MessageBoxKK 
.KK 
ShowKK 
(KK  

PropertiesKK  *
.KK* +
	ResourcesKK+ 4
.KK4 5!
errorConexionServidorKK5 J
,KKJ K

PropertiesKKL V
.KKV W
	ResourcesKKW `
.KK` a
tituloErrorConexionKKa t
,KKt u
MessageBoxButton	KKv �
.
KK� �
OK
KK� �
,
KK� �
MessageBoxImage
KK� �
.
KK� �
Error
KK� �
)
KK� �
;
KK� �
}LL 
}NN 	
}PP 
}QQ ��
jC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Juego.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
Juego 
:  
Window! '
{ 
public 
ServidorJuegoSE 
. 
Jugador &
jugador' .
;. /
public 
List 
< 
String 
> 
chat  
=! "
new# &
List' +
<+ ,
string, 2
>2 3
(3 4
)4 5
;5 6
InstanceContext 
contexto  
;  !
public 
ServidorJuegoSE 
. +
AdministradorMultijugadorClient >
clienteMultijugador? R
;R S
public 
List 
< 
String 
> 
jugadoresConectados /
=0 1
new2 5
List6 :
<: ;
String; A
>A B
(B C
)C D
;D E
private 
List 
< 
ServidorJuegoSE $
.$ %
Casilla% ,
>, -
casillas. 6
;6 7
private 
List 
< 
ServidorJuegoSE $
.$ %
Portal% +
>+ ,
portales- 5
;5 6
private  
CallbackMultijugador $
regresoJuego% 1
;1 2
public 
ServidorJuegoSE 
. 
Sala #
sala$ (
;( )
public 
ServidorJuegoSE 
. 
Ficha $
jugadorEnTurno% 3
=4 5
new6 9
ServidorJuegoSE: I
.I J
FichaJ O
(O P
)P Q
;Q R
private 
MediaPlayer 
musicaFondo '
=( )
new* -
MediaPlayer. 9
(9 :
): ;
;; <
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
regresoMensaje	v �
)
� �
{ 	
jugador   
=   
jugadorRecibido   %
;  % &
sala!! 
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
chat$$' +
;$$+ ,'
listBox_JugadoresConectados%% '
.%%' (
ItemsSource%%( 3
=%%4 5
jugadoresConectados%%6 I
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
clienteMultijugador(( 
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
sala**< @
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
}22 	
public44 
List44 
<44 
ServidorJuegoSE44 #
.44# $
Casilla44$ +
>44+ ,
Casillas44- 5
{446 7
get448 ;
{44< =
return44> D
casillas44E M
;44M N
}44O P
set44Q T
{44U V
casillas44W _
=44` a
value44b g
;44g h
}44i j
}44k l
public55 
List55 
<55 
ServidorJuegoSE55 #
.55# $
Portal55$ *
>55* +
Portales55, 4
{555 6
get557 :
{55; <
return55= C
portales55D L
;55L M
}55N O
set55P S
{55T U
portales55V ^
=55_ `
value55a f
;55f g
}55h i
}55j k
public77 
void77 
InicializarTablero77 &
(77& '
)77' (
{88 	%
ColocarCasillasEspeciales99 %
(99% &
)99& '
;99' (
ColocarPortales:: 
(:: 
):: 
;:: 
};; 	
private== 
void== 
SoundTrackCargado== &
(==& '
object==' -
sender==. 4
,==4 5
	EventArgs==6 ?
e==@ A
)==A B
{>> 	
musicaFondo?? 
.?? 
Play?? 
(?? 
)?? 
;?? 
}@@ 	
privateBB 
voidBB  
SoundTrackFinalizadoBB )
(BB) *
objectBB* 0
senderBB1 7
,BB7 8
	EventArgsBB9 B
eBBC D
)BBD E
{CC 	
musicaFondoDD 
.DD 
PlayDD 
(DD 
)DD 
;DD 
}EE 	
privateee 
voidee %
ColocarCasillasEspecialesee .
(ee. /
)ee/ 0
{ff 	
Imagejj 
casillaEspecialjj !
;jj! "
varkk 
casillasEspecialeskk "
=kk# $
casillaskk% -
.kk- .
Wherekk. 3
(kk3 4
xkk4 5
=>kk6 8
xkk9 :
.kk: ;
Especialkk; C
)kkC D
.kkD E
ToListkkE K
(kkK L
)kkL M
;kkM N
forll 
(ll 
intll 
ill 
=ll 
$numll 
;ll 
ill 
<ll 
casillasEspecialesll  2
.ll2 3
Countll3 8
(ll8 9
)ll9 :
;ll: ;
ill< =
++ll= ?
)ll? @
{mm 
casillaEspecialtt 
=tt  !
newtt" %
Imagett& +
(tt+ ,
)tt, -
;tt- .
casillaEspecialuu 
.uu  
Sourceuu  &
=uu' (
newuu) ,
BitmapImageuu- 8
(uu8 9
newuu9 <
Uriuu= @
(uu@ A
$struuA h
,uuh i
UriKinduuj q
.uuq r
Relativeuur z
)uuz {
)uu{ |
;uu| }
casillaEspecialvv 
.vv  
HorizontalAlignmentvv  3
=vv4 5
HorizontalAlignmentvv6 I
.vvI J
LeftvvJ N
;vvN O
casillaEspecialww 
.ww  
VerticalAlignmentww  1
=ww2 3
VerticalAlignmentww4 E
.wwE F
BottomwwF L
;wwL M
casillaEspecialxx 
.xx  
Heightxx  &
=xx' (
$numxx) +
;xx+ ,
Gridyy 
.yy 
	SetColumnyy 
(yy 
casillaEspecialyy .
,yy. /
casillasEspecialesyy0 B
[yyB C
iyyC D
]yyD E
.yyE F
ColumnayyF M
)yyM N
;yyN O
Gridzz 
.zz 
SetRowzz 
(zz 
casillaEspecialzz +
,zz+ ,
casillasEspecialeszz- ?
[zz? @
izz@ A
]zzA B
.zzB C
FilazzC G
)zzG H
;zzH I
grid_Tablero{{ 
.{{ 
Children{{ %
.{{% &
Add{{& )
({{) *
casillaEspecial{{* 9
){{9 :
;{{: ;
}|| 
}}} 	
private 
void 
ColocarPortales $
($ %
)% &
{
�� 	
ServidorJuegoSE
�� 
.
�� 
Casilla
�� #
casilla
��$ +
;
��+ ,
Image
�� 
imagenPortal
�� 
;
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
�� 
<
�� 
portales
��  (
.
��( )
Count
��) .
;
��. /
i
��0 1
++
��1 3
)
��3 4
{
�� 
casilla
�� 
=
�� 
casillas
�� "
.
��" #
Find
��# '
(
��' (
x
��( )
=>
��* ,
x
��- .
.
��. /
Id
��/ 1
==
��2 4
portales
��5 =
[
��= >
i
��> ?
]
��? @
.
��@ A
	IdCasilla
��A J
)
��J K
;
��K L
imagenPortal
�� 
=
�� 
new
�� "
Image
��# (
(
��( )
)
��) *
;
��* +
imagenPortal
�� 
.
�� 
Source
�� #
=
��$ %
new
��& )
BitmapImage
��* 5
(
��5 6
new
��6 9
Uri
��: =
(
��= >
portales
��> F
[
��F G
i
��G H
]
��H I
.
��I J
	UriPortal
��J S
,
��S T
UriKind
��U \
.
��\ ]
Relative
��] e
)
��e f
)
��f g
;
��g h
imagenPortal
�� 
.
�� !
HorizontalAlignment
�� 0
=
��1 2!
HorizontalAlignment
��3 F
.
��F G
Left
��G K
;
��K L
imagenPortal
�� 
.
�� 
VerticalAlignment
�� .
=
��/ 0
VerticalAlignment
��1 B
.
��B C
Bottom
��C I
;
��I J
imagenPortal
�� 
.
�� 
Height
�� #
=
��$ %
$num
��& (
;
��( )
imagenPortal
�� 
.
�� 
Name
�� !
=
��" #
portales
��$ ,
[
��, -
i
��- .
]
��. /
.
��/ 0
Color
��0 5
+
��6 7
portales
��8 @
[
��@ A
i
��A B
]
��B C
.
��C D
ZonaTablero
��D O
;
��O P
Grid
�� 
.
�� 
SetRow
�� 
(
�� 
imagenPortal
�� (
,
��( )
casilla
��* 1
.
��1 2
Fila
��2 6
)
��6 7
;
��7 8
Grid
�� 
.
�� 
	SetColumn
�� 
(
�� 
imagenPortal
�� +
,
��+ ,
casilla
��- 4
.
��4 5
Columna
��5 <
)
��< =
;
��= >
grid_Tablero
�� 
.
�� 
Children
�� %
.
��% &
Add
��& )
(
��) *
imagenPortal
��* 6
)
��6 7
;
��7 8
}
�� 
}
�� 	
private
�� 
void
�� 
Button_Enviar
�� "
(
��" #
object
��# )
sender
��* 0
,
��0 1
RoutedEventArgs
��2 A
e
��B C
)
��C D
{
�� 	
if
�� 
(
�� 
textBox_Mensaje
�� 
.
��  
Text
��  $
!=
��% '
$str
��( *
)
��* +
{
�� !
clienteMultijugador
�� #
.
��# $ 
EnviarMensajeJuego
��$ 6
(
��6 7
sala
��7 ;
.
��; <
IdSala
��< B
,
��B C
textBox_Mensaje
��D S
.
��S T
Text
��T X
)
��X Y
;
��Y Z
textBox_Mensaje
�� 
.
��  
Clear
��  %
(
��% &
)
��& '
;
��' (
}
�� 
}
�� 	
private
�� 
void
�� 
CerrarVentana
�� "
(
��" #
object
��# )
sender
��* 0
,
��0 1
System
��2 8
.
��8 9
ComponentModel
��9 G
.
��G H
CancelEventArgs
��H W
e
��X Y
)
��Y Z
{
�� 	
musicaFondo
�� 
.
�� 
Stop
�� 
(
�� 
)
�� 
;
�� !
clienteMultijugador
�� 
.
��  

SalirJuego
��  *
(
��* +
sala
��+ /
.
��/ 0
IdSala
��0 6
)
��6 7
;
��7 8
}
�� 	
private
�� 
void
�� 
Button_Salir
�� !
(
��! "
object
��" (
sender
��) /
,
��/ 0
RoutedEventArgs
��1 @
e
��A B
)
��B C
{
�� 	
MenuPrincipal
�� 
menuPrincipal
�� '
=
��( )
new
��* -
MenuPrincipal
��. ;
(
��; <
jugador
��< C
)
��C D
;
��D E
menuPrincipal
�� 
.
�� 
Show
�� 
(
�� 
)
��  
;
��  !
this
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
�� 
}
�� 	
public
�� 
void
�� #
RecibirListaJugadores
�� )
(
��) *
List
��* .
<
��. /
String
��/ 5
>
��5 6
	jugadores
��7 @
)
��@ A
{
�� 	!
jugadoresConectados
�� 
.
��  
AddRange
��  (
(
��( )
	jugadores
��) 2
)
��2 3
;
��3 4)
listBox_JugadoresConectados
�� '
.
��' (
Items
��( -
.
��- .
Refresh
��. 5
(
��5 6
)
��6 7
;
��7 8
}
�� 	
public
�� 
void
�� 
Entrar
�� 
(
�� 
)
�� 
{
�� 	!
clienteMultijugador
�� 
.
��  
UnirseJuego
��  +
(
��+ ,
sala
��, 0
.
��0 1
IdSala
��1 7
,
��7 8
jugador
��9 @
)
��@ A
;
��A B
}
�� 	
public
�� 
void
�� 

MoverFicha
�� 
(
�� 
bool
�� #

cayoPortal
��$ .
)
��. /
{
�� 	
ServidorJuegoSE
�� 
.
�� 
Casilla
�� #
casillaTemporal
��$ 3
=
��4 5
casillas
��6 >
.
��> ?
	ElementAt
��? H
(
��H I
jugadorEnTurno
��I W
.
��W X
Posicion
��X `
-
��a b
$num
��c d
)
��d e
;
��e f
ImageSource
�� 
fuenteFicha
�� #
=
��$ %
new
��& )
BitmapImage
��* 5
(
��5 6
new
��6 9
Uri
��: =
(
��= >
jugadorEnTurno
��> L
.
��L M
UriFicha
��M U
,
��U V
UriKind
��W ^
.
��^ _
Relative
��_ g
)
��g h
)
��h i
;
��i j
var
�� 
imagenesTablero
�� 
=
��  !
grid_Tablero
��" .
.
��. /
Children
��/ 7
.
��7 8
Cast
��8 <
<
��< =
	UIElement
��= F
>
��F G
(
��G H
)
��H I
.
��I J
Where
��J O
(
��O P
i
��P Q
=>
��R T
i
��U V
is
��W Y
Image
��Z _
)
��_ `
.
��` a
Cast
��a e
<
��e f
Image
��f k
>
��k l
(
��l m
)
��m n
;
��n o
var
�� 
fichaAMover
�� 
=
�� 
imagenesTablero
�� -
.
��- .
FirstOrDefault
��. <
(
��< =
i
��= >
=>
��? A
i
��B C
.
��C D
Name
��D H
==
��I K
jugadorEnTurno
��L Z
.
��Z [
NombreFicha
��[ f
)
��f g
;
��g h
Grid
�� 
.
�� 
	SetColumn
�� 
(
�� 
fichaAMover
�� &
,
��& '
casillaTemporal
��( 7
.
��7 8
Columna
��8 ?
)
��? @
;
��@ A
Grid
�� 
.
�� 
SetRow
�� 
(
�� 
fichaAMover
�� #
,
��# $
casillaTemporal
��% 4
.
��4 5
Fila
��5 9
)
��9 :
;
��: ;
var
�� 
portal
�� 
=
�� 
portales
�� !
.
��! "
Find
��" &
(
��& '
x
��' (
=>
��) +
x
��, -
.
��- .
	IdCasilla
��. 7
==
��8 :
casillaTemporal
��; J
.
��J K
Id
��K M
)
��M N
;
��N O
if
�� 
(
�� 
portal
�� 
!=
�� 
null
�� 
&&
�� !
!
��" #

cayoPortal
��# -
)
��- .
{
�� 
var
�� 

otroPortal
�� 
=
��  
portales
��! )
.
��) *
Find
��* .
(
��. /
x
��/ 0
=>
��1 3
x
��4 5
.
��5 6
Color
��6 ;
==
��< >
portal
��? E
.
��E F
Color
��F K
&&
��L N
x
��O P
.
��P Q
ZonaTablero
��Q \
!=
��] _
portal
��` f
.
��f g
ZonaTablero
��g r
)
��r s
;
��s t
jugadorEnTurno
�� 
.
�� 
Posicion
�� '
=
��( )

otroPortal
��* 4
.
��4 5
	IdCasilla
��5 >
;
��> ?
if
�� 
(
�� 
jugadorEnTurno
�� "
.
��" #
ApodoJugador
��# /
==
��0 2
jugador
��3 :
.
��: ;
Apodo
��; @
)
��@ A
{
�� !
clienteMultijugador
�� '
.
��' ("
CambiarPosicionFicha
��( <
(
��< =
sala
��= A
.
��A B
IdSala
��B H
,
��H I
jugadorEnTurno
��J X
)
��X Y
;
��Y Z
}
�� 
DispatcherTimer
�� 
temporizador
��  ,
=
��- .
new
��/ 2
DispatcherTimer
��3 B
(
��B C
)
��C D
;
��D E
temporizador
�� 
.
�� 
Interval
�� %
=
��& '
TimeSpan
��( 0
.
��0 1
FromSeconds
��1 <
(
��< =
$num
��= ?
)
��? @
;
��@ A
temporizador
�� 
.
�� 
Tick
�� !
+=
��" $"
TemporizadorDetenido
��% 9
;
��9 :
temporizador
�� 
.
�� 
Start
�� "
(
��" #
)
��# $
;
��$ %
}
�� 
if
�� 
(
�� 
casillaTemporal
�� 
.
��  
Especial
��  (
&&
��) +
jugadorEnTurno
��, :
.
��: ;
ApodoJugador
��; G
==
��H J
jugador
��K R
.
��R S
Apodo
��S X
)
��X Y
{
�� !
clienteMultijugador
�� #
.
��# $
CambiarPortales
��$ 3
(
��3 4
sala
��4 8
.
��8 9
IdSala
��9 ?
,
��? @
casillas
��A I
.
��I J
ToArray
��J Q
(
��Q R
)
��R S
,
��S T
portales
��U ]
.
��] ^
ToArray
��^ e
(
��e f
)
��f g
)
��g h
;
��h i
}
�� 
}
�� 	
private
�� 
void
�� "
TemporizadorDetenido
�� )
(
��) *
object
��* 0
sender
��1 7
,
��7 8
	EventArgs
��9 B
e
��C D
)
��D E
{
�� 	
var
�� 
temporizador
�� 
=
�� 
sender
�� %
as
��& (
DispatcherTimer
��) 8
;
��8 9
temporizador
�� 
.
�� 
Stop
�� 
(
�� 
)
�� 
;
��  

MoverFicha
�� 
(
�� 
true
�� 
)
�� 
;
�� 
}
�� 	
public
�� 
void
�� #
MostrarFichaEnTablero
�� )
(
��) *
)
��* +
{
�� 	
Image
�� 
imagenFicha
�� 
=
�� 
new
��  #
Image
��$ )
(
��) *
)
��* +
;
��+ ,
imagenFicha
�� 
.
�� 
Source
�� 
=
��  
new
��! $
BitmapImage
��% 0
(
��0 1
new
��1 4
Uri
��5 8
(
��8 9
jugadorEnTurno
��9 G
.
��G H
UriFicha
��H P
,
��P Q
UriKind
��R Y
.
��Y Z
Relative
��Z b
)
��b c
)
��c d
;
��d e
imagenFicha
�� 
.
�� 
Name
�� 
=
�� 
jugadorEnTurno
�� -
.
��- .
NombreFicha
��. 9
;
��9 :
imagenFicha
�� 
.
�� 
Width
�� 
=
�� 
$num
��  "
;
��" #
imagenFicha
�� 
.
�� 
Height
�� 
=
��  
$num
��! #
;
��# $
grid_Tablero
�� 
.
�� 
Children
�� !
.
��! "
Add
��" %
(
��% &
imagenFicha
��& 1
)
��1 2
;
��2 3
Grid
�� 
.
�� 
	SetColumn
�� 
(
�� 
imagenFicha
�� &
,
��& '
$num
��( )
)
��) *
;
��* +
Grid
�� 
.
�� 
SetRow
�� 
(
�� 
imagenFicha
�� #
,
��# $
$num
��% &
)
��& '
;
��' (
}
�� 	
public
�� 
void
�� 
CambiarPortales
�� #
(
��# $
ServidorJuegoSE
��$ 3
.
��3 4
Portal
��4 :
[
��: ;
]
��; <
portalesRecibidos
��= N
)
��N O
{
�� 	
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
�� 
<
�� 
portales
��  (
.
��( )
Count
��) .
;
��. /
i
��0 1
++
��1 3
)
��3 4
{
�� 
var
�� 
casillaDelPortal
�� $
=
��% &
casillas
��' /
.
��/ 0
Find
��0 4
(
��4 5
x
��5 6
=>
��7 9
x
��: ;
.
��; <
Id
��< >
==
��? A
portales
��B J
[
��J K
i
��K L
]
��L M
.
��M N
	IdCasilla
��N W
)
��W X
;
��X Y
var
�� 
imagenesEnCasilla
�� %
=
��& '
grid_Tablero
��( 4
.
��4 5
Children
��5 =
.
��= >
Cast
��> B
<
��B C
	UIElement
��C L
>
��L M
(
��M N
)
��N O
.
��O P
Where
��P U
(
�� 
x
�� 
=>
�� 
x
�� 
is
�� 
Image
�� $
&&
��% '
Grid
��( ,
.
��, -
	GetColumn
��- 6
(
��6 7
x
��7 8
)
��8 9
==
��: <
casillaDelPortal
��= M
.
��M N
Columna
��N U
&&
�� 
Grid
�� 
.
�� 
GetRow
�� "
(
��" #
x
��# $
)
��$ %
==
��& (
casillaDelPortal
��) 9
.
��9 :
Fila
��: >
)
��> ?
.
��? @
Cast
��@ D
<
��D E
Image
��E J
>
��J K
(
��K L
)
��L M
;
��M N
var
�� 
portal
�� 
=
�� 
imagenesEnCasilla
�� .
.
��. /
FirstOrDefault
��/ =
(
��= >
x
��> ?
=>
��@ B
x
��C D
.
��D E
Name
��E I
.
��I J
Equals
��J P
(
��P Q
portales
��Q Y
[
��Y Z
i
��Z [
]
��[ \
.
��\ ]
Color
��] b
+
��c d
portales
��e m
[
��m n
i
��n o
]
��o p
.
��p q
ZonaTablero
��q |
)
��| }
)
��} ~
;
��~ 
var
�� 
nuevaCasilla
��  
=
��! "
casillas
��# +
.
��+ ,
Find
��, 0
(
��0 1
x
��1 2
=>
��3 5
x
��6 7
.
��7 8
Id
��8 :
==
��; =
portalesRecibidos
��> O
[
��O P
i
��P Q
]
��Q R
.
��R S
	IdCasilla
��S \
)
��\ ]
;
��] ^
Grid
�� 
.
�� 
SetRow
�� 
(
�� 
portal
�� "
,
��" #
nuevaCasilla
��$ 0
.
��0 1
Fila
��1 5
)
��5 6
;
��6 7
Grid
�� 
.
�� 
	SetColumn
�� 
(
�� 
portal
�� %
,
��% &
nuevaCasilla
��' 3
.
��3 4
Columna
��4 ;
)
��; <
;
��< =
}
�� 
portales
�� 
=
�� 
portalesRecibidos
�� (
.
��( )
ToList
��) /
(
��/ 0
)
��0 1
;
��1 2
}
�� 	
}
�� 
}�� �
rC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\MenuPrincipal.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public		 

partial		 
class		 
MenuPrincipal		 &
:		' (
Window		) /
{		0 1
private 
ServidorJuegoSE 
.  
Jugador  '
jugador( /
;/ 0
private 
SoundPlayer 
sonidoBoton '
=( )
new* -
SoundPlayer. 9
(9 :
$str: S
)S T
;T U
public 
MenuPrincipal 
( 
ServidorJuegoSE ,
., -
Jugador- 4
jugadorRecibido5 D
)D E
{F G
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
} 	
private 
void $
Button_ConsultarPuntajes -
(- .
object. 4
sender5 ;
,; <
RoutedEventArgs= L
eM N
)N O
{P Q
sonidoBoton 
. 
Play 
( 
) 
; 
ConsultarPuntajes 
ventanaPuntajes -
=. /
new0 3
ConsultarPuntajes4 E
(E F
jugadorF M
)M N
;N O
ventanaPuntajes 
. 
Show  
(  !
)! "
;" #
this 
. 
Close 
( 
) 
; 
} 	
private 
void 
Button_CerrarSesion (
(( )
object) /
sender0 6
,6 7
RoutedEventArgs8 G
eH I
)I J
{K L
sonidoBoton 
. 
Play 
( 
) 
; 

MainWindow 
ventanaIncio #
=$ %
new& )

MainWindow* 4
(4 5
)5 6
;6 7
ventanaIncio 
. 
Show 
( 
) 
;  
this 
. 
Close 
( 
) 
; 
} 	
private!! 
void!! 
Button_NuevaPartida!! (
(!!( )
object!!) /
sender!!0 6
,!!6 7
RoutedEventArgs!!8 G
e!!H I
)!!I J
{"" 	
sonidoBoton## 
.## 
Play## 
(## 
)## 
;## 
CrearPartida$$ 
ventanaCrearPartida$$ ,
=$$- .
new$$/ 2
CrearPartida$$3 ?
($$? @
jugador$$@ G
)$$G H
;$$H I
ventanaCrearPartida%% 
.%%  
Show%%  $
(%%$ %
)%%% &
;%%& '
this&& 
.&& 
Close&& 
(&& 
)&& 
;&& 
}'' 	
private)) 
void))  
Button_BuscarPartida)) )
())) *
object))* 0
sender))1 7
,))7 8
RoutedEventArgs))9 H
e))I J
)))J K
{** 	
sonidoBoton++ 
.++ 
Play++ 
(++ 
)++ 
;++ 
BuscarPartida,,  
ventanaBuscarPartida,, .
=,,/ 0
new,,1 4
BuscarPartida,,5 B
(,,B C
jugador,,C J
),,J K
;,,K L 
ventanaBuscarPartida--  
.--  !
Show--! %
(--% &
)--& '
;--' (
this.. 
... 
Close.. 
(.. 
).. 
;.. 
}// 	
}11 
}22 �L
tC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\RegistroUsuario.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
RegistroUsuario (
:) *
Window+ 1
{ 
public 
RegistroUsuario 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Regresar $
($ %
object% +
sender, 2
,2 3
RoutedEventArgs4 C
eD E
)E F
{G H

MainWindow 
ventanaPrincipal '
=( )
new* -

MainWindow. 8
(8 9
)9 :
;: ;
ventanaPrincipal 
. 
Show !
(! "
)" #
;# $
this 
. 
Close 
( 
) 
; 
}   	
private** 
void** 
Button_Registrarse** '
(**' (
object**( .
sender**/ 5
,**5 6
RoutedEventArgs**7 F
e**G H
)**H I
{**J K
if++ 
(++ 
!++ 
ValidarCampos++ 
(++ 
)++  
||++! #
!++$ % 
ValidarFormatoCorreo++% 9
(++9 :
)++: ;
)++; <
{,, 
return-- 
;-- 
}.. 
ServidorJuegoSE// 
.// %
AdministradorCuentaClient// 5
cliente//6 =
=//> ?
new//@ C
ServidorJuegoSE//D S
.//S T%
AdministradorCuentaClient//T m
(//m n
)//n o
;//o p
ServidorJuegoSE00 
.00 
Cuenta00 "
cuenta00# )
=00* +
new00, /
ServidorJuegoSE000 ?
.00? @
Cuenta00@ F
(00F G
)00G H
{00I J
Correo00K Q
=00R S%
textBox_CorreoElectronico00T m
.00m n
Text00n r
,00r s
Contraseña00t ~
=	00 �%
passwordBox_Contraseña
00� �
.
00� �
Password
00� �
}
00� �
;
00� �
ServidorJuegoSE11 
.11 
Jugador11 #
jugador11$ +
=11, -
new11. 1
ServidorJuegoSE112 A
.11A B
Jugador11B I
(11I J
)11J K
{11L M
Apodo11N S
=11T U
textBox_Apodo11V c
.11c d
Text11d h
,11h i
Nombre11j p
=11q r"
textBox_NombreUsuario	11s �
.
11� �
Text
11� �
,
11� �
	Apellidos
11� �
=
11� �
textBox_Apellidos
11� �
.
11� �
Text
11� �
}
11� �
;
11� �
int22 
	respuesta22 
;22 
try33 
{44 
	respuesta55 
=55 
cliente55 #
.55# $
RegistrarJugador55$ 4
(554 5
jugador555 <
,55< =
cuenta55> D
)55D E
;55E F
if66 
(66 
	respuesta66 
==66  
$num66! "
)66" #
{77 
cliente88 
.88 
EnviarCorreo88 (
(88( )
cuenta88) /
)88/ 0
;880 1
IngresarCodigo99 "
ingresarCodigo99# 1
=992 3
new994 7
IngresarCodigo998 F
(99F G
cuenta99G M
)99M N
;99N O
ingresarCodigo:: "
.::" #
Show::# '
(::' (
)::( )
;::) *
this;; 
.;; 
Close;; 
(;; 
);;  
;;;  !
}<< 
}== 
catch>> 
(>> 
System>> 
.>> 
ServiceModel>> &
.>>& '%
EndpointNotFoundException>>' @
)>>@ A
{?? 

MessageBox@@ 
.@@ 
Show@@ 
(@@  

Properties@@  *
.@@* +
	Resources@@+ 4
.@@4 5!
errorConexionServidor@@5 J
,@@J K

Properties@@L V
.@@V W
	Resources@@W `
.@@` a
tituloErrorConexion@@a t
,@@t u
MessageBoxButton	@@v �
.
@@� �
OK
@@� �
,
@@� �
MessageBoxImage
@@� �
.
@@� �
Error
@@� �
)
@@� �
;
@@� �
returnAA 
;AA 
}BB 
ifCC 
(CC 
	respuestaCC 
==CC 
-CC 
$numCC 
)CC  
{DD 
stringEE 
usuarioRepetidoEE &
=EE' (

PropertiesEE) 3
.EE3 4
	ResourcesEE4 =
.EE= >
usuarioRepetidoEE> M
;EEM N

MessageBoxFF 
.FF 
ShowFF 
(FF  
usuarioRepetidoFF  /
)FF/ 0
;FF0 1
returnGG 
;GG 
}HH 
ifII 
(II 
	respuestaII 
==II 
-II 
$numII 
)II  
{JJ 
stringKK 
correoRepetidoKK %
=KK& '

PropertiesKK( 2
.KK2 3
	ResourcesKK3 <
.KK< =
correoRepetidoKK= K
;KKK L

MessageBoxLL 
.LL 
ShowLL 
(LL  
correoRepetidoLL  .
)LL. /
;LL/ 0
returnMM 
;MM 
}NN 
ifOO 
(OO 
	respuestaOO 
==OO 
-OO 
$numOO  
||OO! #
	respuestaOO$ -
==OO. 0
-OO1 2
$numOO2 4
)OO4 5
{PP 

MessageBoxQQ 
.QQ 
ShowQQ 
(QQ  

PropertiesQQ  *
.QQ* +
	ResourcesQQ+ 4
.QQ4 5"
errorConexionBaseDatosQQ5 K
,QQK L

PropertiesQQM W
.QQW X
	ResourcesQQX a
.QQa b
tituloErrorConexionQQb u
,QQu v
MessageBoxButton	QQw �
.
QQ� �
OK
QQ� �
,
QQ� �
MessageBoxImage
QQ� �
.
QQ� �
Error
QQ� �
)
QQ� �
;
QQ� �
returnRR 
;RR 
}SS 
}TT 	
private\\ 
Boolean\\ 
ValidarCampos\\ %
(\\% &
)\\& '
{\\( )
if^^ 
(^^ !
textBox_NombreUsuario^^ %
.^^% &
Text^^& *
==^^+ -
$str^^. 0
||^^1 3
textBox_Apellidos^^4 E
.^^E F
Text^^F J
==^^K M
$str^^M O
||^^P R
textBox_Apodo^^S `
.^^` a
Text^^a e
==^^e g
$str^^h j
||^^k m&
textBox_CorreoElectronico	^^n �
.
^^� �
Text
^^� �
==
^^� �
$str
^^� �
||__ #
passwordBox_Contraseña__ )
.__) *
SecurePassword__* 8
.__8 9
Length__9 ?
==__@ B
$num__C D
||__E G,
 passwordBox_ConfirmarContraseña__H g
.__g h
SecurePassword__h v
.__v w
Length__w }
==	__~ �
$num
__� �
)
__� �
{
__� �
string`` 
camposObligatorios`` )
=``* +

Properties``, 6
.``6 7
	Resources``7 @
.``@ A
camposObligatorios``A S
;``S T

MessageBoxaa 
.aa 
Showaa 
(aa  
camposObligatoriosaa  2
)aa2 3
;aa3 4
returnbb 
falsebb 
;bb 
}cc 
elsedd 
ifdd 
(dd 
!dd #
passwordBox_Contraseñadd ,
.dd, -
Passworddd- 5
.dd5 6
Equalsdd6 <
(dd< =,
 passwordBox_ConfirmarContraseñadd= \
.dd\ ]
Passworddd] e
)dde f
)ddf g
{ee 
stringff 
contraseñaInvalidaff )
=ff* +

Propertiesff, 6
.ff6 7
	Resourcesff7 @
.ff@ A!
contraseñaNoCoincideffA U
;ffU V

MessageBoxgg 
.gg 
Showgg 
(gg  
contraseñaInvalidagg  2
)gg2 3
;gg3 4
returnhh 
falsehh 
;hh 
}ii 
returnjj 
truejj 
;jj 
}kk 	
privateqq 
Booleanqq  
ValidarFormatoCorreoqq ,
(qq, -
)qq- .
{rr 	
Stringss 
	expresionss 
=ss 
$strss T
;ssT U
iftt 
(tt 
Regextt 
.tt 
IsMatchtt 
(tt %
textBox_CorreoElectronicott 7
.tt7 8
Texttt8 <
,tt< =
	expresiontt> G
)ttG H
)ttH I
{uu 
ifvv 
(vv 
Regexvv 
.vv 
Replacevv !
(vv! "%
textBox_CorreoElectronicovv" ;
.vv; <
Textvv< @
,vv@ A
	expresionvvB K
,vvK L
StringvvM S
.vvS T
EmptyvvT Y
)vvY Z
.vvZ [
Lengthvv[ a
==vvb d
$numvve f
)vvf g
{ww 
returnxx 
truexx 
;xx  
}yy 
}zz 

MessageBox{{ 
.{{ 
Show{{ 
({{ 

Properties{{ &
.{{& '
	Resources{{' 0
.{{0 1
correoInvalido{{1 ?
){{? @
;{{@ A
return|| 
false|| 
;|| 
}}} 	
} 
}�� �D
jC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Lobby.xaml.cs
	namespace 	
SerpientesEscaleras
 
{		 
public 

partial 
class 
Lobby 
:  
Window! '
{ 
private 
ServidorJuegoSE 
.  
Jugador  '
jugador( /
;/ 0
public 
List 
< 
String 
> 
chat  
=! "
new# &
List' +
<+ ,
string, 2
>2 3
(3 4
)4 5
;5 6
InstanceContext 
contexto  
;  !
private 
ServidorJuegoSE 
.  +
AdministradorMultijugadorClient  ?
clienteMultijugador@ S
;S T
public 
List 
< 
String 
> 
jugadoresConectados /
=0 1
new2 5
List6 :
<: ;
String; A
>A B
(B C
)C D
;D E
private  
CallbackMultijugador $
regresoMensaje% 3
;3 4
private 
ServidorJuegoSE 
.  
Sala  $
sala% )
;) *
public 
Lobby 
( 
ServidorJuegoSE $
.$ %
Jugador% ,
jugadorRecibido- <
)< =
{ 	
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
listBox_Chat 
. 
ItemsSource $
=% &
chat' +
;+ ,'
listBox_JugadoresConectados '
.' (
ItemsSource( 3
=4 5
jugadoresConectados6 I
;I J
regresoMensaje 
= 
new   
CallbackMultijugador! 5
{ 
Lobby 
= 
this 
} 
; 
contexto 
= 
new 
InstanceContext *
(* +
regresoMensaje+ 9
)9 :
;: ;
clienteMultijugador   
=    !
new  " %
ServidorJuegoSE  & 5
.  5 6+
AdministradorMultijugadorClient  6 U
(  U V
contexto  V ^
)  ^ _
;  _ `
}!! 	
public## 
void## 
CrearPartida##  
(##  !
ServidorJuegoSE##! 0
.##0 1
Sala##1 5
salaRecibida##6 B
)##B C
{$$ 	
sala%% 
=%% 
salaRecibida%% 
;%%  
sala&& 
.&& 
IdSala&& 
=&& 
clienteMultijugador&& -
.&&- .
	CrearSala&&. 7
(&&7 8
sala&&8 <
)&&< =
;&&= >
clienteMultijugador'' 
.''  

UnirseSala''  *
(''* +
sala''+ /
.''/ 0
IdSala''0 6
,''6 7
jugador''8 ?
)''? @
;''@ A
}(( 	
public** 
Boolean** 
EntrarPartida** $
(**$ %
ServidorJuegoSE**% 4
.**4 5
Sala**5 9
salaRecibida**: F
)**F G
{++ 	
sala,, 
=,, 
salaRecibida,, 
;,,  
if-- 
(-- 
clienteMultijugador-- #
.--# $
ValidarSala--$ /
(--/ 0
sala--0 4
.--4 5
IdSala--5 ;
)--; <
)--< =
{.. 
jugadoresConectados// #
=//$ %
clienteMultijugador//& 9
.//9 :"
ConsultarJugadoresSala//: P
(//P Q
sala//Q U
.//U V
IdSala//V \
)//\ ]
.//] ^
ToList//^ d
(//d e
)//e f
;//f g'
listBox_JugadoresConectados00 +
.00+ ,
ItemsSource00, 7
=008 9
jugadoresConectados00: M
;00M N
clienteMultijugador11 #
.11# $

UnirseSala11$ .
(11. /
sala11/ 3
.113 4
IdSala114 :
,11: ;
jugador11< C
)11C D
;11D E
return22 
true22 
;22 
}33 
return44 
false44 
;44 
}55 	
public77 
List77 
<77 
ServidorJuegoSE77 #
.77# $
Sala77$ (
>77( )(
ConsultarPartidasDisponibles77* F
(77F G
)77G H
{88 	
return99 
clienteMultijugador99 &
.99& '%
ConsultarSalasDisponibles99' @
(99@ A
)99A B
.99B C
ToList99C I
(99I J
)99J K
;99K L
}:: 	
private<< 
void<< 
Button_Enviar<< "
(<<" #
object<<# )
sender<<* 0
,<<0 1
RoutedEventArgs<<2 A
e<<B C
)<<C D
{== 	
if>> 
(>> 
textBox_Mensaje>> 
.>>  
Text>>  $
!=>>% '
$str>>( *
)>>* +
{?? 
clienteMultijugador@@ #
.@@# $
EnviarMensaje@@$ 1
(@@1 2
sala@@2 6
.@@6 7
IdSala@@7 =
,@@= >
textBox_Mensaje@@? N
.@@N O
Text@@O S
)@@S T
;@@T U
textBox_MensajeAA 
.AA  
ClearAA  %
(AA% &
)AA& '
;AA' (
}BB 
}CC 	
privateEE 
voidEE 
CerrarVentanaEE "
(EE" #
objectEE# )
senderEE* 0
,EE0 1
SystemEE2 8
.EE8 9
ComponentModelEE9 G
.EEG H
CancelEventArgsEEH W
eEEX Y
)EEY Z
{FF 	
clienteMultijugadorGG 
.GG  
	SalirChatGG  )
(GG) *
salaGG* .
.GG. /
IdSalaGG/ 5
)GG5 6
;GG6 7
}HH 	
privateJJ 
voidJJ 
Button_RegresarJJ $
(JJ$ %
objectJJ% +
senderJJ, 2
,JJ2 3
RoutedEventArgsJJ4 C
eJJD E
)JJE F
{KK 	
MenuPrincipalLL 
menuPrincipalLL '
=LL( )
newLL* -
MenuPrincipalLL. ;
(LL; <
jugadorLL< C
)LLC D
;LLD E
menuPrincipalMM 
.MM 
ShowMM 
(MM 
)MM  
;MM  !
thisNN 
.NN 
CloseNN 
(NN 
)NN 
;NN 
}OO 	
privateQQ 
voidQQ 
Button_JugarQQ !
(QQ! "
objectQQ" (
senderQQ) /
,QQ/ 0
RoutedEventArgsQQ1 @
eQQA B
)QQB C
{RR 	
clienteMultijugadorSS 
.SS  
IniciarJuegoSS  ,
(SS, -
salaSS- 1
.SS1 2
IdSalaSS2 8
)SS8 9
;SS9 :
}TT 	
publicVV 
voidVV 
EntrarJuegoVV 
(VV  
ServidorJuegoSEVV  /
.VV/ 0
CasillaVV0 7
[VV7 8
]VV8 9
casillasVV: B
,VVB C
ServidorJuegoSEVVD S
.VVS T
PortalVVT Z
[VVZ [
]VV[ \
portalesVV] e
)VVe f
{WW 	
JuegoXX 
juegoXX 
=XX 
newXX 
JuegoXX #
(XX# $
jugadorXX$ +
,XX+ ,
salaXX- 1
,XX1 2
regresoMensajeXX3 A
)XXA B
;XXB C
juegoYY 
.YY !
RecibirListaJugadoresYY '
(YY' (
jugadoresConectadosYY( ;
)YY; <
;YY< =
juegoZZ 
.ZZ 
CasillasZZ 
=ZZ 
casillasZZ %
.ZZ% &
ToListZZ& ,
(ZZ, -
)ZZ- .
;ZZ. /
juego[[ 
.[[ 
Portales[[ 
=[[ 
portales[[ %
.[[% &
ToList[[& ,
([[, -
)[[- .
;[[. /
juego\\ 
.\\ 
InicializarTablero\\ $
(\\$ %
)\\% &
;\\& '
juego]] 
.]] 
Show]] 
(]] 
)]] 
;]] 
this^^ 
.^^ 
Close^^ 
(^^ 
)^^ 
;^^ 
juego__ 
.__ 
Entrar__ 
(__ 
)__ 
;__ 
}`` 	
}bb 
}cc �B
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
public 
BuscarPartida 
( 
ServidorJuegoSE ,
., -
Jugador- 4
jugadorRecibido5 D
)D E
{ 	
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
lobby 
= 
new 
Lobby 
( 
jugadorRecibido -
)- .
;. /

listaSalas 
= 
lobby 
. (
ConsultarPartidasDisponibles ;
(; <
)< =
;= >
dataGrid_Partidas 
. 
ItemsSource )
=* +

listaSalas, 6
;6 7
} 	
private 
void 
Button_Entrar "
(" #
object# )
sender* 0
,0 1
RoutedEventArgs2 A
eB C
)C D
{ 	
if 
( 
dataGrid_Partidas !
.! "
SelectedItem" .
==/ 1
null2 6
)6 7
{ 
string 
elegir 
= 

Properties  *
.* +
	Resources+ 4
.4 5
elegirPartida5 B
;B C

MessageBox 
. 
Show 
(  
elegir  &
)& '
;' (
return 
; 
} 
ServidorJuegoSE   
.   
Sala    
partida  ! (
=  ) *
(  + ,
ServidorJuegoSE  , ;
.  ; <
Sala  < @
)  @ A
dataGrid_Partidas  A R
.  R S
SelectedItem  S _
;  _ `
if!! 
(!! 
!!! 
lobby!! 
.!! 
EntrarPartida!! $
(!!$ %
partida!!% ,
)!!, -
)!!- .
{"" 

listaSalas## 
.## 
Clear##  
(##  !
)##! "
;##" #
string$$ 
partidaRecurso$$ %
=$$& '

Properties$$( 2
.$$2 3
	Resources$$3 <
.$$< =
partida$$= D
;$$D E
string%% 
llena%% 
=%% 

Properties%% )
.%%) *
	Resources%%* 3
.%%3 4
llena%%4 9
;%%9 :

MessageBox)) 
.)) 
Show)) 
())  
partidaRecurso))  .
+))/ 0
$str))1 4
+))5 6
partida))7 >
.))> ?
Nombre))? E
+))F G
$str))H K
+))L M
llena))N S
)))S T
;))T U

listaSalas++ 
=++ 
lobby++ "
.++" #(
ConsultarPartidasDisponibles++# ?
(++? @
)++@ A
;++A B
dataGrid_Partidas,, !
.,,! "
Items,," '
.,,' (
Refresh,,( /
(,,/ 0
),,0 1
;,,1 2
return-- 
;-- 
}.. 
lobby// 
.// 
Show// 
(// 
)// 
;// 
this00 
.00 
Close00 
(00 
)00 
;00 
}11 	
private33 
void33 
Button_Regresar33 $
(33$ %
object33% +
sender33, 2
,332 3
RoutedEventArgs334 C
e33D E
)33E F
{44 	
MenuPrincipal55  
ventanaMenuPrincipal55 .
=55/ 0
new551 4
MenuPrincipal555 B
(55B C
jugador55C J
)55J K
;55K L 
ventanaMenuPrincipal66  
.66  !
Show66! %
(66% &
)66& '
;66' (
this77 
.77 
Close77 
(77 
)77 
;77 
}88 	
private:: 
void:: 2
&DataGrid_Partidas_AutoGeneratingColumn:: ;
(::; <
object::< B
sender::C I
,::I J1
%DataGridAutoGeneratingColumnEventArgs::K p
e::q r
)::r s
{;; 	
string<< 
titulo<< 
=<< 
e<< 
.<< 
Column<< $
.<<$ %
Header<<% +
.<<+ ,
ToString<<, 4
(<<4 5
)<<5 6
;<<6 7
if== 
(== 
titulo== 
==== 
$str== (
||==) +
titulo==, 2
====3 5
$str==6 G
||==H J
titulo==K Q
====R T
$str==U k
)==k l
{>> 
e?? 
.?? 
Cancel?? 
=?? 
true?? 
;??  
}@@ 
ifAA 
(AA 
tituloAA 
==AA 
$strAA "
)AA" #
{BB 
eCC 
.CC 
ColumnCC 
.CC 
DisplayIndexCC %
=CC% &
$numCC& '
;CC' (
}DD 
ifEE 
(EE 
tituloEE 
==EE 
$strEE (
)EE( )
{FF 
stringGG 
numJugadoresGG #
=GG$ %

PropertiesGG& 0
.GG0 1
	ResourcesGG1 :
.GG: ;
numJugadoresGG; G
;GGG H
eHH 
.HH 
ColumnHH 
.HH 
HeaderHH 
=HH  !
numJugadoresHH" .
;HH. /
eII 
.II 
ColumnII 
.II 
DisplayIndexII %
=II& '
$numII( )
;II) *
}JJ 
ifKK 
(KK 
tituloKK 
==KK 
$strKK %
)KK% &
{LL 
stringMM 
	dobleDadoMM  
=MM! "

PropertiesMM# -
.MM- .
	ResourcesMM. 7
.MM7 8
	dobleDadoMM8 A
;MMA B
eNN 
.NN 
ColumnNN 
.NN 
HeaderNN 
=NN  !
	dobleDadoNN" +
;NN+ ,
eOO 
.OO 
ColumnOO 
.OO 
DisplayIndexOO %
=OO& '
$numOO( )
;OO) *
}PP 
ifQQ 
(QQ 
tituloQQ 
==QQ 
$strQQ &
)QQ& '
{RR 
stringSS 

dobleFichaSS !
=SS" #

PropertiesSS$ .
.SS. /
	ResourcesSS/ 8
.SS8 9

dobleFichaSS9 C
;SSC D
eTT 
.TT 
ColumnTT 
.TT 
HeaderTT 
=TT  !

dobleFichaTT" ,
;TT, -
eUU 
.UU 
ColumnUU 
.UU 
DisplayIndexUU %
=UU& '
$numUU( )
;UU) *
}VV 
ifWW 
(WW 
tituloWW 
==WW 
$strWW .
)WW. /
{XX 
stringYY 
casillaEspecialYY &
=YY' (

PropertiesYY) 3
.YY3 4
	ResourcesYY4 =
.YY= >
casillaEspecialYY> M
;YYM N
eZZ 
.ZZ 
ColumnZZ 
.ZZ 
HeaderZZ 
=ZZ  !
casillaEspecialZZ" 1
;ZZ1 2
e[[ 
.[[ 
Column[[ 
.[[ 
DisplayIndex[[ %
=[[& '
$num[[( )
;[[) *
}\\ 
if]] 
(]] 
titulo]] 
==]] 
$str]] #
)]]# $
{^^ 
e__ 
.__ 
Column__ 
.__ 
Header__ 
=__  !
$str__" 5
;__5 6
e`` 
.`` 
Column`` 
.`` 
DisplayIndex`` %
=``& '
$num``( )
;``) *
}aa 
}bb 	
}cc 
}dd �H
qC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\CrearPartida.xaml.cs
	namespace		 	
SerpientesEscaleras		
 
{

 
public 

partial 
class 
CrearPartida %
:& '
Window( .
{ 
private 
ServidorJuegoSE 
.  
Jugador  '
jugador( /
=0 1
new2 5
ServidorJuegoSE6 E
.E F
JugadorF M
(M N
)N O
;O P
public 
CrearPartida 
( 
ServidorJuegoSE +
.+ ,
Jugador, 3
jugadorRecibido4 C
)C D
{ 	
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
textBox_Nombre 
. 
Focus  
(  !
)! "
;" #
} 	
private 
void $
TextBox_Nombre_LostFocus -
(- .
object. 4
sender5 ;
,; <
RoutedEventArgs= L
eM N
)N O
{ 	
if 
( 
textBox_Nombre 
. 
Text #
==$ &
$str' )
)) *
{ 
label_Nombre 
. 

Visibility '
=( )

Visibility* 4
.4 5
Visible5 <
;< =
} 
} 	
private 
void "
TextBox_Nombre_KeyDown +
(+ ,
object, 2
sender3 9
,9 :
KeyEventArgs; G
eH I
)I J
{ 	
label_Nombre   
.   

Visibility   #
=  $ %

Visibility  & 0
.  0 1
Hidden  1 7
;  7 8
}!! 	
private## 
void## "
Label_Nombre_MouseDown## +
(##+ ,
object##, 2
sender##3 9
,##9 : 
MouseButtonEventArgs##; O
e##P Q
)##Q R
{$$ 	
textBox_Nombre%% 
.%% 
Focus%%  
(%%  !
)%%! "
;%%" #
}&& 	
private(( 
void(( 
Button_Regresar(( $
((($ %
object((% +
sender((, 2
,((2 3
RoutedEventArgs((4 C
e((D E
)((E F
{)) 	
MenuPrincipal** 
menuPrincipal** '
=**( )
new*** -
MenuPrincipal**. ;
(**; <
jugador**< C
)**C D
;**D E
menuPrincipal++ 
.++ 
Show++ 
(++ 
)++  
;++  !
this,, 
.,, 
Close,, 
(,, 
),, 
;,, 
}-- 	
private// 
void// 
Button_CrearPartida// (
(//( )
object//) /
sender//0 6
,//6 7
RoutedEventArgs//8 G
e//H I
)//I J
{00 	
if11 
(11 
!11 
VerificarCampos11  
(11  !
)11! "
)11" #
{22 
return33 
;33 
}44 
var55 

rectangulo55 
=55 
grid_Fondos55 (
.55( )
Children55) 1
.551 2
Cast552 6
<556 7
	UIElement557 @
>55@ A
(55A B
)55B C
.55C D
FirstOrDefault55D R
(55R S
i55S T
=>55U W
i55X Y
is55Z \
	Rectangle55] f
&&55g i
i55j k
.55k l
Opacity55l s
==55t v
$num55w x
)55x y
;55y z
var66 
fondo66 
=66 
(66 
Image66 
)66 
grid_Fondos66 *
.66* +
Children66+ 3
.663 4
Cast664 8
<668 9
	UIElement669 B
>66B C
(66C D
)66D E
.66E F
First66F K
(66K L
i66L M
=>66N P
i66Q R
is66S U
Image66V [
&&66\ ^
Grid66_ c
.66c d
	GetColumn66d m
(66m n
i66n o
)66o p
==66q s
Grid66t x
.66x y
	GetColumn	66y �
(
66� �

rectangulo
66� �
)
66� �
)
66� �
;
66� �
ServidorJuegoSE77 
.77 
Sala77  
sala77! %
=77& '
new77( +
ServidorJuegoSE77, ;
.77; <
Sala77< @
(77@ A
)77A B
{88 
Nombre99 
=99 
textBox_Nombre99 '
.99' (
Text99( ,
,99, -
	DobleDado:: 
=:: 
checkBox_DobleDado:: .
.::. /
	IsChecked::/ 8
.::8 9
Value::9 >
,::> ?

DobleFicha;; 
=;; 
checkBox_DobleFicha;; 0
.;;0 1
	IsChecked;;1 :
.;;: ;
Value;;; @
,;;@ A
CasillasEspeciales<< "
=<<# $'
checkBox_CasillasEspeciales<<% @
.<<@ A
	IsChecked<<A J
.<<J K
Value<<K P
,<<P Q
UriFondoTablero== 
===  !
(==" #
(==# $
BitmapFrame==$ /
)==/ 0
fondo==0 5
.==5 6
Source==6 <
)==< =
.=== >
Decoder==> E
.==E F
ToString==F N
(==N O
)==O P
}>> 
;>> 
Lobby?? 
lobby?? 
=?? 
new?? 
Lobby?? #
(??# $
jugador??$ +
)??+ ,
;??, -
lobby@@ 
.@@ 
CrearPartida@@ 
(@@ 
sala@@ #
)@@# $
;@@$ %
lobbyAA 
.AA 
ShowAA 
(AA 
)AA 
;AA 
thisBB 
.BB 
CloseBB 
(BB 
)BB 
;BB 
}CC 	
privateEE 
voidEE 
Rectangle_ClicEE #
(EE# $
objectEE$ *
senderEE+ 1
,EE1 2 
MouseButtonEventArgsEE3 G
eEEH I
)EEI J
{FF 	
	RectangleGG 

rectanguloGG  
=GG! "
senderGG# )
asGG* ,
	RectangleGG- 6
;GG6 7
varHH "
rectanguloSeleccionadoHH &
=HH' (
grid_FondosHH) 4
.HH4 5
ChildrenHH5 =
.HH= >
CastHH> B
<HHB C
	UIElementHHC L
>HHL M
(HHM N
)HHN O
.HHO P
FirstOrDefaultHHP ^
(HH^ _
iHH_ `
=>HHa c
iHHd e
isHHf h
	RectangleHHi r
&&HHs u
iHHv w
.HHw x
OpacityHHx 
==
HH� �
$num
HH� �
)
HH� �
;
HH� �
ifII 
(II "
rectanguloSeleccionadoII &
!=II' )
nullII* .
)II. /
{JJ "
rectanguloSeleccionadoKK &
.KK& '
OpacityKK' .
=KK/ 0
$numKK1 2
;KK2 3
}LL 

rectanguloMM 
.MM 
OpacityMM 
=MM  
$numMM! "
;MM" #
}NN 	
privatePP 
boolPP 
VerificarCamposPP $
(PP$ %
)PP% &
{QQ 	
ifRR 
(RR 
textBox_NombreRR 
.RR 
TextRR #
.RR# $
EqualsRR$ *
(RR* +
$strRR+ -
)RR- .
)RR. /
{SS 
stringTT 
nombreObligatorioTT (
=TT) *

PropertiesTT+ 5
.TT5 6
	ResourcesTT6 ?
.TT? @
nombreObligatorioTT@ Q
;TTQ R

MessageBoxUU 
.UU 
ShowUU 
(UU  
nombreObligatorioUU  1
)UU1 2
;UU2 3
returnVV 
falseVV 
;VV 
}WW 
varXX "
rectanguloSeleccionadoXX &
=XX' (
grid_FondosXX) 4
.XX4 5
ChildrenXX5 =
.XX= >
CastXX> B
<XXB C
	UIElementXXC L
>XXL M
(XXM N
)XXN O
.XXO P
FirstOrDefaultXXP ^
(XX^ _
iXX_ `
=>XXa c
iXXd e
isXXf h
	RectangleXXi r
&&XXs u
iXXv w
.XXw x
OpacityXXx 
==
XX� �
$num
XX� �
)
XX� �
;
XX� �
ifYY 
(YY "
rectanguloSeleccionadoYY &
==YY' )
nullYY* .
)YY. /
{ZZ 
string[[  
escenarioObligatorio[[ +
=[[, -

Properties[[. 8
.[[8 9
	Resources[[9 B
.[[B C 
escenarioObligatorio[[C W
;[[W X

MessageBox\\ 
.\\ 
Show\\ 
(\\   
escenarioObligatorio\\  4
)\\4 5
;\\5 6
return]] 
false]] 
;]] 
}^^ 
return__ 
true__ 
;__ 
}`` 	
}aa 
}bb ��
jC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Turno.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
Turno 
:  
Window! '
{ 
private 
Juego 
juego 
; 
public 
ServidorJuegoSE 
. 
Ficha $
ficha% *
;* +
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
Turno 
( 
Juego 
juegoReferencia *
)* +
{ 	
juego 
= 
juegoReferencia #
;# $
InitializeComponent 
(  
)  !
;! "
} 	
public   
void   
ElegirFicha   
(    
List    $
<  $ %
ServidorJuegoSE  % 4
.  4 5
Ficha  5 :
>  : ;
fichasEscogidas  < K
)  K L
{!! 	
label_Instruccion"" 
."" 
Content"" %
=""& '
$str""( 9
;""9 :
ColumnDefinition## 
columna## $
;##$ %
String$$ 
uri$$ 
;$$ 
Image%% 
imagenFicha%% 
;%% 
	Rectangle&& 

rectangulo&&  
;&&  !
for'' 
('' 
int'' 
i'' 
='' 
$num'' 
;'' 
i'' 
<=''  
$num''! "
;''" #
i''$ %
++''% '
)''' (
{(( 
uri)) 
=)) 
$str)) 7
+))8 9
i)): ;
+))< =
$str))> D
;))D E
if** 
(** 
fichasEscogidas** #
.**# $
Find**$ (
(**( )
x**) *
=>**+ -
x**. /
.**/ 0
UriFicha**0 8
.**8 9
Equals**9 ?
(**? @
uri**@ C
)**C D
)**D E
==**F H
null**I M
)**M N
{++ 
columna,, 
=,, 
new,, !
ColumnDefinition,," 2
(,,2 3
),,3 4
;,,4 5
columna-- 
.-- 
Width-- !
=--" #
new--$ '

GridLength--( 2
(--2 3
$num--3 6
)--6 7
;--7 8
grid_Fichas.. 
...  
ColumnDefinitions..  1
...1 2
Add..2 5
(..5 6
columna..6 =
)..= >
;..> ?
imagenFicha// 
=//  !
new//" %
Image//& +
(//+ ,
)//, -
;//- .
imagenFicha00 
.00  
Source00  &
=00' (
new00) ,
BitmapImage00- 8
(008 9
new009 <
Uri00= @
(00@ A
uri00A D
,00D E
UriKind00F M
.00M N
Relative00N V
)00V W
)00W X
;00X Y
imagenFicha11 
.11  
Name11  $
=11% &
$str11' .
+11. /
i11/ 0
;110 1

rectangulo22 
=22  
new22! $
	Rectangle22% .
(22. /
)22/ 0
;220 1

rectangulo33 
.33 
Stretch33 &
=33' (
Stretch33) 0
.330 1
Fill331 5
;335 6

rectangulo44 
.44 
Stroke44 %
=44& '
new44( +
SolidColorBrush44, ;
(44; <
Colors44< B
.44B C
Azure44C H
)44H I
;44I J

rectangulo55 
.55 
StrokeThickness55 .
=55/ 0
$num551 2
;552 3

rectangulo66 
.66 
Opacity66 &
=66' (
$num66) *
;66* +

rectangulo77 
.77 
Fill77 #
=77$ %
new77& )
SolidColorBrush77* 9
(779 :
Colors77: @
.77@ A
Transparent77A L
)77L M
;77M N

rectangulo88 
.88 
	MouseDown88 (
+=88) +
Rectangle_Clic88, :
;88: ;
Grid99 
.99 
	SetColumn99 "
(99" #
imagenFicha99# .
,99. /
i990 1
-992 3
$num994 5
)995 6
;996 7
Grid:: 
.:: 
	SetColumn:: "
(::" #

rectangulo::# -
,::- .
i::/ 0
-::1 2
$num::3 4
)::4 5
;::5 6
grid_Fichas;; 
.;;  
Children;;  (
.;;( )
Add;;) ,
(;;, -
imagenFicha;;- 8
);;8 9
;;;9 :
grid_Fichas<< 
.<<  
Children<<  (
.<<( )
Add<<) ,
(<<, -

rectangulo<<- 7
)<<7 8
;<<8 9
}== 
}>> 
scrollViewer_Fichas?? 
.??  

Visibility??  *
=??+ ,

Visibility??- 7
.??7 8
Visible??8 ?
;??? @
button_Elegir@@ 
.@@ 

Visibility@@ $
=@@% &

Visibility@@' 1
.@@1 2
Visible@@2 9
;@@9 :
button_ElegirAA 
.AA 
ContentAA !
=AA" #
$strAA$ ,
;AA, -
}BB 	
privateDD 
voidDD 
Rectangle_ClicDD #
(DD# $
objectDD$ *
senderDD+ 1
,DD1 2 
MouseButtonEventArgsDD3 G
eDDH I
)DDI J
{EE 	
	RectangleFF 

rectanguloFF  
=FF! "
senderFF# )
asFF* ,
	RectangleFF- 6
;FF6 7
varGG "
rectanguloSeleccionadoGG &
=GG' (
grid_FichasGG) 4
.GG4 5
ChildrenGG5 =
.GG= >
CastGG> B
<GGB C
	UIElementGGC L
>GGL M
(GGM N
)GGN O
.GGO P
FirstOrDefaultGGP ^
(GG^ _
iGG_ `
=>GGa c
iGGd e
isGGf h
	RectangleGGi r
&&GGs u
iGGv w
.GGw x
OpacityGGx 
==
GG� �
$num
GG� �
)
GG� �
;
GG� �
ifHH 
(HH "
rectanguloSeleccionadoHH &
!=HH' )
nullHH* .
)HH. /
{II "
rectanguloSeleccionadoJJ &
.JJ& '
OpacityJJ' .
=JJ/ 0
$numJJ1 2
;JJ2 3
}KK 

rectanguloLL 
.LL 
OpacityLL 
=LL  
$numLL! "
;LL" #
}MM 	
privateOO 
voidOO 
Button_ElegirOO "
(OO" #
objectOO# )
senderOO* 0
,OO0 1
RoutedEventArgsOO2 A
eOOB C
)OOC D
{PP 	
varQQ 

rectanguloQQ 
=QQ 
grid_FichasQQ (
.QQ( )
ChildrenQQ) 1
.QQ1 2
CastQQ2 6
<QQ6 7
	UIElementQQ7 @
>QQ@ A
(QQA B
)QQB C
.QQC D
FirstOrDefaultQQD R
(QQR S
iQQS T
=>QQU W
iQQX Y
isQQZ \
	RectangleQQ] f
&&QQg i
iQQj k
.QQk l
OpacityQQl s
==QQt v
$numQQw x
)QQx y
;QQy z
ifRR 
(RR 

rectanguloRR 
==RR 
nullRR "
)RR" #
{SS 

MessageBoxTT 
.TT 
ShowTT 
(TT  
$strTT  7
)TT7 8
;TT8 9
returnUU 
;UU 
}VV 
varWW 
direccionFichaWW 
=WW  
(WW! "
ImageWW" '
)WW' (
grid_FichasWW( 3
.WW3 4
ChildrenWW4 <
.WW< =
CastWW= A
<WWA B
	UIElementWWB K
>WWK L
(WWL M
)WWM N
.WWN O
FirstWWO T
(WWT U
iWWU V
=>WWW Y
iWWZ [
isWW\ ^
ImageWW_ d
&&WWe g
GridWWh l
.WWl m
	GetColumnWWm v
(WWv w
iWWw x
)WWx y
==WWz |
Grid	WW} �
.
WW� �
	GetColumn
WW� �
(
WW� �

rectangulo
WW� �
)
WW� �
)
WW� �
;
WW� �
fichaXX 
=XX 
newXX 
ServidorJuegoSEXX '
.XX' (
FichaXX( -
(XX- .
)XX. /
{YY 
NombreFichaZZ 
=ZZ 
direccionFichaZZ ,
.ZZ, -
NameZZ- 1
,ZZ1 2
UriFicha[[ 
=[[ 
([[ 
([[ 
BitmapImage[[ (
)[[( )
direccionFicha[[) 7
.[[7 8
Source[[8 >
)[[> ?
.[[? @
	UriSource[[@ I
.[[I J
OriginalString[[J X
,[[X Y
ApodoJugador\\ 
=\\ 
juego\\ $
.\\$ %
jugador\\% ,
.\\, -
Apodo\\- 2
,\\2 3
Posicion]] 
=]] 
$num]] 
}^^ 
;^^ 
cerrar__ 
=__ 
true__ 
;__ 
this`` 
.`` 
Close`` 
(`` 
)`` 
;`` 
juegoaa 
.aa 
clienteMultijugadoraa %
.aa% &
AsignarFichaaa& 2
(aa2 3
juegoaa3 8
.aa8 9
salaaa9 =
.aa= >
IdSalaaa> D
,aaD E
fichaaaF K
)aaK L
;aaL M
}bb 	
publicdd 
voiddd 
Tirardd 
(dd 
)dd 
{ee 	
label_Instruccionff 
.ff 
Contentff %
=ff& '
$strff( 7
;ff7 8
button_Tirargg 
.gg 
Contentgg  
=gg! "
$strgg# *
;gg* +

grid_Dadoshh 
.hh 

Visibilityhh !
=hh" #

Visibilityhh$ .
.hh. /
Visiblehh/ 6
;hh6 7
ifii 
(ii 
juegoii 
.ii 
salaii 
.ii 
	DobleDadoii $
)ii$ %
{jj 
MostrarDadoskk 
(kk 
$numkk 
)kk 
;kk  
image_Dado2ll 
.ll 

Visibilityll &
=ll' (

Visibilityll) 3
.ll3 4
Visiblell4 ;
;ll; <
}mm 
elsenn 
{oo 
MostrarDadospp 
(pp 
$numpp 
)pp 
;pp  
}qq 

image_Dadorr 
.rr 

Visibilityrr !
=rr" #

Visibilityrr$ .
.rr. /
Visiblerr/ 6
;rr6 7
}ss 	
privateuu 
voiduu 
Button_Tiraruu !
(uu! "
objectuu" (
senderuu) /
,uu/ 0
RoutedEventArgsuu1 @
euuA B
)uuB C
{vv 	
button_Tirarww 
.ww 

Visibilityww #
=ww$ %

Visibilityww& 0
.ww0 1
Hiddenww1 7
;ww7 8
numeroDado1xx 
=xx 
	aleatorioxx #
.xx# $
Nextxx$ (
(xx( )
$numxx) *
,xx* +
$numxx, -
)xx- .
;xx. /
ifyy 
(yy 
juegoyy 
.yy 
salayy 
.yy 
	DobleDadoyy $
)yy$ %
{zz 
numeroDado2{{ 
={{ 
	aleatorio{{ '
.{{' (
Next{{( ,
({{, -
$num{{- .
,{{. /
$num{{0 1
){{1 2
;{{2 3
controladorGif2|| 
.||  
Play||  $
(||$ %
)||% &
;||& '
}}} 
controladorGif~~ 
.~~ 
Play~~ 
(~~  
)~~  !
;~~! "
} 	
private
�� 
void
�� 
gif_Cargado
��  
(
��  !
object
��! '
sender
��( .
,
��. /
RoutedEventArgs
��0 ?
e
��@ A
)
��A B
{
�� 	
controladorGif
�� 
=
�� 
ImageBehavior
�� *
.
��* +$
GetAnimationController
��+ A
(
��A B

image_Dado
��B L
)
��L M
;
��M N
button_Tirar
�� 
.
�� 

Visibility
�� #
=
��$ %

Visibility
��& 0
.
��0 1
Visible
��1 8
;
��8 9
}
�� 	
private
�� 
void
�� 
gif2_Cargado
�� !
(
��! "
object
��" (
sender
��) /
,
��/ 0
RoutedEventArgs
��1 @
e
��A B
)
��B C
{
�� 	
controladorGif2
�� 
=
�� 
ImageBehavior
�� +
.
��+ ,$
GetAnimationController
��, B
(
��B C
image_Dado2
��C N
)
��N O
;
��O P
}
�� 	
private
�� 
void
�� 
gif_Terminado
�� "
(
��" #
object
��# )
sender
��* 0
,
��0 1
RoutedEventArgs
��2 A
e
��B C
)
��C D
{
�� 	

image_Dado
�� 
.
�� 

Visibility
�� !
=
��" #

Visibility
��$ .
.
��. /
	Collapsed
��/ 8
;
��8 9
Image
�� 
caraDado
�� 
=
�� 
new
��  
Image
��! &
(
��& '
)
��' (
;
��( )
String
�� 
uri
�� 
=
�� 
$str
�� 7
+
��8 9
numeroDado1
��: E
+
��F G
$str
��H N
;
��N O
caraDado
�� 
.
�� 
Source
�� 
=
�� 
new
�� !
BitmapImage
��" -
(
��- .
new
��. 1
Uri
��2 5
(
��5 6
uri
��6 9
,
��9 :
UriKind
��; B
.
��B C
Relative
��C K
)
��K L
)
��L M
;
��M N
Grid
�� 
.
�� 
	SetColumn
�� 
(
�� 
caraDado
�� #
,
��# $
$num
��% &
)
��& '
;
��' (

grid_Dados
�� 
.
�� 
Children
�� 
.
��  
Add
��  #
(
��# $
caraDado
��$ ,
)
��, -
;
��- .
DispatcherTimer
�� 
temporizador
�� (
=
��) *
new
��+ .
DispatcherTimer
��/ >
(
��> ?
)
��? @
;
��@ A
temporizador
�� 
.
�� 
Interval
�� !
=
��" #
TimeSpan
��$ ,
.
��, -
FromSeconds
��- 8
(
��8 9
$num
��9 ;
)
��; <
;
��< =
temporizador
�� 
.
�� 
Tick
�� 
+=
��  "
temporizadorDetenido
��! 5
;
��5 6
temporizador
�� 
.
�� 
Start
�� 
(
�� 
)
��  
;
��  !
}
�� 	
private
�� 
void
�� 
gif2_Terminado
�� #
(
��# $
object
��$ *
sender
��+ 1
,
��1 2
RoutedEventArgs
��3 B
e
��C D
)
��D E
{
�� 	
image_Dado2
�� 
.
�� 

Visibility
�� "
=
��# $

Visibility
��% /
.
��/ 0
	Collapsed
��0 9
;
��9 :
Image
�� 
caraDado
�� 
=
�� 
new
��  
Image
��! &
(
��& '
)
��' (
;
��( )
String
�� 
uri
�� 
=
�� 
$str
�� 7
+
��8 9
numeroDado2
��: E
+
��F G
$str
��H N
;
��N O
caraDado
�� 
.
�� 
Source
�� 
=
�� 
new
�� !
BitmapImage
��" -
(
��- .
new
��. 1
Uri
��2 5
(
��5 6
uri
��6 9
,
��9 :
UriKind
��; B
.
��B C
Relative
��C K
)
��K L
)
��L M
;
��M N
Grid
�� 
.
�� 
	SetColumn
�� 
(
�� 
caraDado
�� #
,
��# $
$num
��% &
)
��& '
;
��' (

grid_Dados
�� 
.
�� 
Children
�� 
.
��  
Add
��  #
(
��# $
caraDado
��$ ,
)
��, -
;
��- .
}
�� 	
private
�� 
void
�� "
temporizadorDetenido
�� )
(
��) *
object
��* 0
sender
��1 7
,
��7 8
	EventArgs
��9 B
e
��C D
)
��D E
{
�� 	
var
�� 
temporizador
�� 
=
�� 
sender
�� %
as
��& (
DispatcherTimer
��) 8
;
��8 9
temporizador
�� 
.
�� 
Stop
�� 
(
�� 
)
�� 
;
��  
cerrar
�� 
=
�� 
true
�� 
;
�� 
this
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
�� 
juego
�� 
.
�� !
clienteMultijugador
�� %
.
��% &
RecibirTiro
��& 1
(
��1 2
juego
��2 7
.
��7 8
sala
��8 <
.
��< =
IdSala
��= C
,
��C D
numeroDado1
��E P
+
��Q R
numeroDado2
��S ^
)
��^ _
;
��_ `
}
�� 	
private
�� 
void
�� 
MostrarDados
�� !
(
��! "
int
��" %
numDados
��& .
)
��. /
{
�� 	
ColumnDefinition
�� 
columna
�� $
;
��$ %
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
�� 
<
�� 
numDados
��  (
;
��( )
i
��* +
++
��+ -
)
��- .
{
�� 
var
�� 
gifDado
�� 
=
�� 
new
�� !
BitmapImage
��" -
(
��- .
)
��. /
;
��/ 0
gifDado
�� 
.
�� 
	BeginInit
�� !
(
��! "
)
��" #
;
��# $
gifDado
�� 
.
�� 
	UriSource
�� !
=
��" #
new
��$ '
Uri
��( +
(
��+ ,
$str
��, N
,
��N O
UriKind
��P W
.
��W X
Relative
��X `
)
��` a
;
��a b
gifDado
�� 
.
�� 
EndInit
�� 
(
��  
)
��  !
;
��! "
columna
�� 
=
�� 
new
�� 
ColumnDefinition
�� .
(
��. /
)
��/ 0
;
��0 1
columna
�� 
.
�� 
Width
�� 
=
�� 
new
��  #

GridLength
��$ .
(
��. /
$num
��/ 2
)
��2 3
;
��3 4

grid_Dados
�� 
.
�� 
ColumnDefinitions
�� ,
.
��, -
Add
��- 0
(
��0 1
columna
��1 8
)
��8 9
;
��9 :
if
�� 
(
�� 
i
�� 
==
�� 
$num
�� 
)
�� 
{
�� 
ImageBehavior
�� !
.
��! "
SetAnimatedSource
��" 3
(
��3 4

image_Dado
��4 >
,
��> ?
gifDado
��@ G
)
��G H
;
��H I
Grid
�� 
.
�� 
	SetColumn
�� "
(
��" #

image_Dado
��# -
,
��- .
i
��/ 0
)
��0 1
;
��1 2
}
�� 
else
�� 
{
�� 
ImageBehavior
�� !
.
��! "
SetAnimatedSource
��" 3
(
��3 4
image_Dado2
��4 ?
,
��? @
gifDado
��A H
)
��H I
;
��I J
Grid
�� 
.
�� 
	SetColumn
�� "
(
��" #

image_Dado
��# -
,
��- .
i
��/ 0
)
��0 1
;
��1 2
}
�� 
}
�� 
}
�� 	
public
�� 
void
�� 
MostrarGanador
�� "
(
��" #
ServidorJuegoSE
��# 2
.
��2 3
Ficha
��3 8
fichaGanador
��9 E
)
��E F
{
�� 	
label_Instruccion
�� 
.
�� 
Content
�� %
=
��& '
$str
��( 9
+
��: ;
fichaGanador
��< H
.
��H I
ApodoJugador
��I U
;
��U V
ColumnDefinition
�� 
columna
�� $
=
��% &
new
��' *
ColumnDefinition
��+ ;
(
��; <
)
��< =
;
��= >
columna
�� 
.
�� 
Width
�� 
=
�� 
new
�� 

GridLength
��  *
(
��* +
$num
��+ .
)
��. /
;
��/ 0

grid_Dados
�� 
.
�� 
ColumnDefinitions
�� (
.
��( )
Add
��) ,
(
��, -
columna
��- 4
)
��4 5
;
��5 6
Image
�� 
imagenGanador
�� 
=
��  !
new
��" %
Image
��& +
(
��+ ,
)
��, -
;
��- .
imagenGanador
�� 
.
�� 
Source
��  
=
��! "
new
��# &
BitmapImage
��' 2
(
��2 3
new
��3 6
Uri
��7 :
(
��: ;
fichaGanador
��; G
.
��G H
UriFicha
��H P
,
��P Q
UriKind
��R Y
.
��Y Z
Relative
��Z b
)
��b c
)
��c d
;
��d e
imagenGanador
�� 
.
�� 
Width
�� 
=
��  !
$num
��" %
;
��% &

grid_Dados
�� 
.
�� 
Children
�� 
.
��  
Add
��  #
(
��# $
imagenGanador
��$ 1
)
��1 2
;
��2 3
Grid
�� 
.
�� 
	SetColumn
�� 
(
�� 
imagenGanador
�� (
,
��( )
$num
��* +
)
��+ ,
;
��, -
Grid
�� 
.
�� 
SetRow
�� 
(
�� 
imagenGanador
�� %
,
��% &
$num
��' (
)
��( )
;
��) *
button_Salir
�� 
.
�� 
Content
��  
=
��! "
$str
��# *
;
��* +
button_Salir
�� 
.
�� 

Visibility
�� #
=
��$ %

Visibility
��& 0
.
��0 1
Visible
��1 8
;
��8 9

grid_Dados
�� 
.
�� 

Visibility
�� !
=
��" #

Visibility
��$ .
.
��. /
Visible
��/ 6
;
��6 7
}
�� 	
private
�� 
void
�� 
Cerrando
�� 
(
�� 
object
�� $
sender
��% +
,
��+ ,
System
��- 3
.
��3 4
ComponentModel
��4 B
.
��B C
CancelEventArgs
��C R
e
��S T
)
��T U
{
�� 	
if
�� 
(
�� 
!
�� 
cerrar
�� 
)
�� 
{
�� 
e
�� 
.
�� 
Cancel
�� 
=
�� 
true
�� 
;
��  
}
�� 
}
�� 	
private
�� 
void
�� 
Button_Salir
�� !
(
��! "
object
��" (
sender
��) /
,
��/ 0
RoutedEventArgs
��1 @
e
��A B
)
��B C
{
�� 	
cerrar
�� 
=
�� 
true
�� 
;
�� 
MenuPrincipal
�� 
menuPrincipal
�� '
=
��( )
new
��* -
MenuPrincipal
��. ;
(
��; <
juego
��< A
.
��A B
jugador
��B I
)
��I J
;
��J K
menuPrincipal
�� 
.
�� 
Show
�� 
(
�� 
)
��  
;
��  !
this
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
�� 
}
�� 	
}
�� 
}�� �
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
} �o
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
{ 
public 

MainWindow 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
textBox_Usuario 
. 
Focus !
(! "
)" #
;# $
} 	
private!! 
void!!  
Button_IniciarSesion!! )
(!!) *
object!!* 0
sender!!1 7
,!!7 8
RoutedEventArgs!!9 H
e!!I J
)!!J K
{"" 	
String## 
correoIngresado## "
=### $
textBox_Usuario##% 4
.##4 5
Text##5 9
;##9 :
String$$  
contraseñaIngresada$$ &
=$$' (#
passwordBox_contraseña$$) ?
.$$? @
Password$$@ H
;$$H I
if%% 
(%% 
!%% 
ValidarCamposVacios%% $
(%%$ %
)%%% &
||%%' )
!%%* + 
ValidarFormatoCorreo%%+ ?
(%%? @
)%%@ A
)%%A B
{&& 
return'' 
;'' 
}(( 
ServidorJuegoSE)) 
.)) %
AdministradorCuentaClient)) 5
cliente))6 =
=))> ?
new))@ C
ServidorJuegoSE))D S
.))S T%
AdministradorCuentaClient))T m
())m n
)))n o
;))o p
ServidorJuegoSE** 
.** 
Cuenta** "
cuenta**# )
=*** +
new**, /
ServidorJuegoSE**0 ?
.**? @
Cuenta**@ F
(**F G
)**G H
{**I J
Correo**K Q
=**R S
correoIngresado**T c
,**c d
Contraseña**e o
=**p q!
contraseñaIngresada	**r �
}
**� �
;
**� �
ServidorJuegoSE++ 
.++ 
Jugador++ #
jugador++$ +
=++, -
new++. 1
ServidorJuegoSE++2 A
.++A B
Jugador++B I
(++I J
)++J K
;++K L
try,, 
{-- 
jugador.. 
=.. 
cliente.. !
...! "
IniciarSesion.." /
(../ 0
cuenta..0 6
)..6 7
;..7 8
cuenta// 
=// 
cliente//  
.//  !
VerificarCuenta//! 0
(//0 1
cuenta//1 7
)//7 8
;//8 9
}11 
catch22 
(22 
System22 
.22 
ServiceModel22 &
.22& '%
EndpointNotFoundException22' @
)22@ A
{33 

MessageBox44 
.44 
Show44 
(44  

Properties44  *
.44* +
	Resources44+ 4
.444 5!
errorConexionServidor445 J
,44J K

Properties44L V
.44V W
	Resources44W `
.44` a
tituloErrorConexion44a t
,44t u
MessageBoxButton	44v �
.
44� �
OK
44� �
,
44� �
MessageBoxImage
44� �
.
44� �
Error
44� �
)
44� �
;
44� �
return55 
;55 
}66 
if77 
(77 
jugador77 
!=77 
null77 
&&77  "
cuenta77# )
!=77* ,
null77, 0
)770 1
{88 
if99 
(99 
cuenta99 
.99 
Correo99 !
.99! "
Equals99" (
(99( )
$str99) A
)99A B
||99C E
jugador99F M
.99M N
Apodo99N S
.99S T
Equals99T Z
(99Z [
$str99[ s
)99s t
)99t u
{:: 

MessageBox;; 
.;; 
Show;; #
(;;# $

Properties;;$ .
.;;. /
	Resources;;/ 8
.;;8 9"
errorConexionBaseDatos;;9 O
,;;O P

Properties;;Q [
.;;[ \
	Resources;;\ e
.;;e f
tituloErrorConexion;;f y
,;;y z
MessageBoxButton	;;{ �
.
;;� �
OK
;;� �
,
;;� �
MessageBoxImage
;;� �
.
;;� �
Error
;;� �
)
;;� �
;
;;� �
return<< 
;<< 
}== 
if>> 
(>> 
cuenta>> 
.>> 
Validada>> #
)>># $
{?? 
MenuPrincipal@@ !
ventanaPrincipal@@" 2
=@@3 4
new@@5 8
MenuPrincipal@@9 F
(@@F G
jugador@@G N
)@@N O
;@@O P
ventanaPrincipalAA $
.AA$ %
ShowAA% )
(AA) *
)AA* +
;AA+ ,
thisBB 
.BB 
CloseBB 
(BB 
)BB  
;BB  !
}CC 
elseDD 
{EE 
IngresarCodigoFF "!
ventanaIngresarCodigoFF# 8
=FF9 :
newFF; >
IngresarCodigoFF? M
(FFM N
cuentaFFN T
)FFT U
;FFU V!
ventanaIngresarCodigoGG )
.GG) *
ShowGG* .
(GG. /
)GG/ 0
;GG0 1
thisHH 
.HH 
CloseHH 
(HH 
)HH  
;HH  !
}II 
}JJ 
elseKK 
{LL 

MessageBoxMM 
.MM 
ShowMM 
(MM  

PropertiesMM  *
.MM* +
	ResourcesMM+ 4
.MM4 5'
usuarioContraseñaInvalidasMM5 O
)MMO P
;MMP Q
}NN 
}OO 	
privateVV 
voidVV 
Button_RegistrarseVV '
(VV' (
objectVV( .
senderVV/ 5
,VV5 6
RoutedEventArgsVV7 F
eVVG H
)VVH I
{WW 	
RegistroUsuarioXX 
ventanaRegistroXX +
=XX, -
newXX. 1
RegistroUsuarioXX2 A
(XXA B
)XXB C
;XXC D
ventanaRegistroYY 
.YY 
ShowYY  
(YY  !
)YY! "
;YY" #
thisZZ 
.ZZ 
CloseZZ 
(ZZ 
)ZZ 
;ZZ 
}[[ 	
privatebb 
voidbb !
CambiarIdiomaEspañolbb )
(bb) *
objectbb* 0
senderbb1 7
,bb7 8
RoutedEventArgsbb9 H
ebbI J
)bbJ K
{cc 	
Systemdd 
.dd 
	Threadingdd 
.dd 
Threaddd #
.dd# $
CurrentThreaddd$ 1
.dd1 2
CurrentUICulturedd2 B
=ddC D
newddE H
SystemddI O
.ddO P
GlobalizationddP ]
.dd] ^
CultureInfodd^ i
(ddi j
$strddj l
)ddl m
;ddm n

MainWindowee 
loginee 
=ee 
newee "

MainWindowee# -
(ee- .
)ee. /
;ee/ 0
loginff 
.ff 
Showff 
(ff 
)ff 
;ff 
thisgg 
.gg 
Closegg 
(gg 
)gg 
;gg 
}hh 	
privateoo 
voidoo 
CambiarIdiomaInglesoo (
(oo( )
objectoo) /
senderoo0 6
,oo6 7
RoutedEventArgsoo8 G
eooH I
)ooI J
{pp 	
Systemqq 
.qq 
	Threadingqq 
.qq 
Threadqq #
.qq# $
CurrentThreadqq$ 1
.qq1 2
CurrentUICultureqq2 B
=qqC D
newqqE H
SystemqqI O
.qqO P
GlobalizationqqP ]
.qq] ^
CultureInfoqq^ i
(qqi j
$strqqj q
)qqq r
;qqr s

MainWindowrr 
loginrr 
=rr 
newrr "

MainWindowrr# -
(rr- .
)rr. /
;rr/ 0
loginss 
.ss 
Showss 
(ss 
)ss 
;ss 
thistt 
.tt 
Closett 
(tt 
)tt 
;tt 
}uu 	
public{{ 
bool{{ 
ValidarCamposVacios{{ '
({{' (
){{( )
{|| 	
if~~ 
(~~ 
textBox_Usuario~~ 
.~~  
Text~~  $
==~~% '
$str~~( *
)~~+ ,
{ 
string
�� 
ingresaUsuario
�� %
=
��& '

Properties
��( 2
.
��2 3
	Resources
��3 <
.
��< =
ingresaUsuario
��= K
;
��K L

MessageBox
�� 
.
�� 
Show
�� 
(
��  
ingresaUsuario
��  .
)
��. /
;
��/ 0
return
�� 
false
�� 
;
�� 
}
�� 
else
�� 
if
�� 
(
�� %
passwordBox_contraseña
�� +
.
��+ ,
SecurePassword
��, :
.
��: ;
Length
��; A
==
��B D
$num
��E F
)
��F G
{
�� 
string
��  
ingresaContraseña
�� (
=
��) *

Properties
��+ 5
.
��5 6
	Resources
��6 ?
.
��? @ 
ingresaContraseña
��@ Q
;
��Q R

MessageBox
�� 
.
�� 
Show
�� 
(
��   
ingresaContraseña
��  1
)
��1 2
;
��2 3
return
�� 
false
�� 
;
�� 
}
�� 
return
�� 
true
�� 
;
�� 
}
�� 	
private
�� 
void
�� '
TextBox_Usuario_LostFocus
�� .
(
��. /
object
��/ 5
sender
��6 <
,
��< =
RoutedEventArgs
��> M
e
��N O
)
��O P
{
�� 	
if
�� 
(
�� 
textBox_Usuario
�� 
.
��  
Text
��  $
==
��% '
$str
��( *
)
��* +
{
�� 
label_Usuario
�� 
.
�� 

Visibility
�� (
=
��) *

Visibility
��+ 5
.
��5 6
Visible
��6 =
;
��= >
}
�� 
}
�� 	
private
�� 
void
�� /
!PasswordBox_Contraseña_LostFocus
�� 5
(
��5 6
object
��6 <
sender
��= C
,
��C D
RoutedEventArgs
��E T
e
��U V
)
��V W
{
�� 	
if
�� 
(
�� %
passwordBox_contraseña
�� &
.
��& '
Password
��' /
==
��0 2
$str
��3 5
)
��5 6
{
�� 
label_Contraseña
��  
.
��  !

Visibility
��! +
=
��, -

Visibility
��. 8
.
��8 9
Visible
��9 @
;
��@ A
}
�� 
}
�� 	
private
�� 
void
�� !
PasswordBox_KeyDown
�� (
(
��( )
object
��) /
sender
��0 6
,
��6 7
KeyEventArgs
��8 D
e
��E F
)
��F G
{
�� 	
label_Contraseña
�� 
.
�� 

Visibility
�� '
=
��( )

Visibility
��* 4
.
��4 5
Hidden
��5 ;
;
��; <
}
�� 	
private
�� 
void
�� %
TextBox_Usuario_KeyDown
�� ,
(
��, -
object
��- 3
sender
��4 :
,
��: ;
KeyEventArgs
��< H
e
��I J
)
��J K
{
�� 	
label_Usuario
�� 
.
�� 

Visibility
�� $
=
��% &

Visibility
��' 1
.
��1 2
Hidden
��2 8
;
��8 9
}
�� 	
private
�� 
void
�� )
Label_Contraseña_MouseDown
�� /
(
��/ 0
object
��0 6
sender
��7 =
,
��= >"
MouseButtonEventArgs
��? S
e
��T U
)
��U V
{
�� 	%
passwordBox_contraseña
�� "
.
��" #
Focus
��# (
(
��( )
)
��) *
;
��* +
}
�� 	
private
�� 
void
�� %
Label_Usuario_MouseDown
�� ,
(
��, -
object
��- 3
sender
��4 :
,
��: ;"
MouseButtonEventArgs
��< P
e
��Q R
)
��R S
{
�� 	
textBox_Usuario
�� 
.
�� 
Focus
�� !
(
��! "
)
��" #
;
��# $
}
�� 	
private
�� 
Boolean
�� "
ValidarFormatoCorreo
�� ,
(
��, -
)
��- .
{
�� 	
String
�� 
	expresion
�� 
=
�� 
$str
�� T
;
��T U
if
�� 
(
�� 
System
�� 
.
�� 
Text
�� 
.
��  
RegularExpressions
�� .
.
��. /
Regex
��/ 4
.
��4 5
IsMatch
��5 <
(
��< =
textBox_Usuario
��= L
.
��L M
Text
��M Q
,
��Q R
	expresion
��S \
)
��\ ]
)
��] ^
{
�� 
if
�� 
(
�� 
System
�� 
.
�� 
Text
�� 
.
��   
RegularExpressions
��  2
.
��2 3
Regex
��3 8
.
��8 9
Replace
��9 @
(
��@ A
textBox_Usuario
��A P
.
��P Q
Text
��Q U
,
��U V
	expresion
��W `
,
��` a
String
��b h
.
��h i
Empty
��i n
)
��n o
.
��o p
Length
��p v
==
��w y
$num
��z {
)
��{ |
{
�� 
return
�� 
true
�� 
;
��  
}
�� 
}
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
�� 

Properties
�� &
.
��& '
	Resources
��' 0
.
��0 1
correoInvalido
��1 ?
)
��? @
;
��@ A
return
�� 
false
�� 
;
�� 
}
�� 	
}
�� 
}�� �
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