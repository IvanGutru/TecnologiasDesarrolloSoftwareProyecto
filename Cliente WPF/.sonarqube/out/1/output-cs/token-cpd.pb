€
vC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\ConsultarPuntajes.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
ConsultarPuntajes *
:+ ,
Window- 3
{4 5
private 

ServidorSE 
. 
Jugador "
jugador# *
;* +
public 
ConsultarPuntajes  
(  !

ServidorSE! +
.+ ,
Jugador, 3
jugadorRecibido4 C
)C D
{E F
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "

ServidorSE 
. %
AdministradorCuentaClient 0
cliente1 8
=9 :
new; >

ServidorSE? I
.I J%
AdministradorCuentaClientJ c
(c d
)d e
;e f 
DataGrid_MisPuntajes  
.  !
ItemsSource! ,
=- .
cliente/ 6
.6 7$
ConsultarPuntajesPropios7 O
(O P
jugadorP W
)W X
;X Y$
DataGrid_MejoresPuntajes $
.$ %
ItemsSource% 0
=1 2
cliente3 :
.: ;$
ConsultarMejoresPuntajes; S
(S T
)T U
;U V
} 	
private 
void 
Button_Click !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{D E
MenuPrincipal   
ventanaPrincipal   *
=  + ,
new  - 0
MenuPrincipal  1 >
(  > ?
jugador  ? F
)  F G
;  G H
ventanaPrincipal!! 
.!! 
Show!! !
(!!! "
)!!" #
;!!# $
this"" 
."" 
Close"" 
("" 
)"" 
;"" 
}## 	
}$$ 
}%% ç"
sC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\IngresarCodigo.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
IngresarCodigo '
:( )
Window* 0
{1 2
private 
readonly 

ServidorSE #
.# $
Cuenta$ *
cuenta+ 1
;1 2
public 
IngresarCodigo 
( 

ServidorSE (
.( )
Cuenta) /
cuentaRecibida0 >
)> ?
{@ A
cuenta 
= 
cuentaRecibida #
;# $
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Salir !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{D E

MainWindow 
vetanaPrincipal &
=' (
new) ,

MainWindow- 7
(7 8
)8 9
;9 :
vetanaPrincipal 
. 
Show  
(  !
)! "
;" #
this 
. 
Close 
( 
) 
; 
} 	
private 
void  
Button_ValidarCuenta )
() *
object* 0
sender1 7
,7 8
RoutedEventArgs9 H
eI J
)J K
{L M
if   
(   
textBox_Codigo   
.   
Text   #
!=  $ &
$str  & (
)  ( )
{  * +

ServidorSE!! 
.!! %
AdministradorCuentaClient!! 4
cliente!!5 <
=!!= >
new!!? B

ServidorSE!!C M
.!!M N%
AdministradorCuentaClient!!N g
(!!g h
)!!h i
;!!i j
if"" 
("" 
cliente"" 
.""  
ActivarCuentaJugador"" 0
(""0 1
cuenta""1 7
,""7 8
textBox_Codigo""9 G
.""G H
Text""H L
)""L M
)""M N
{## 
var$$ 
cuentaActivada$$ &
=$$' (

Properties$$) 3
.$$3 4
	Resources$$4 =
.$$= >
cuentaActivada$$> L
;$$L M

MessageBox%% 
.%% 
Show%% #
(%%# $
cuentaActivada%%$ 2
)%%2 3
;%%3 4

MainWindow&& 
vetanaPrincipal&& .
=&&/ 0
new&&1 4

MainWindow&&5 ?
(&&? @
)&&@ A
;&&A B
vetanaPrincipal'' #
.''# $
Show''$ (
(''( )
)'') *
;''* +
this(( 
.(( 
Close(( 
((( 
)((  
;((  !
})) 
else** 
{++ 
string,, 
codigoInvalido,, )
=,,* +

Properties,,, 6
.,,6 7
	Resources,,7 @
.,,@ A
codigoInvalido,,A O
;,,O P

MessageBox-- 
.-- 
Show-- #
(--# $
codigoInvalido--$ 2
)--2 3
;--3 4
}.. 
}// 
else// 
{// 
string00 
ingresarCodigo00 %
=00& '

Properties00( 2
.002 3
	Resources003 <
.00< =$
ingresarCodigoActivacion00= U
;00U V

MessageBox11 
.11 
Show11 
(11  
ingresarCodigo11  .
)11. /
;11/ 0
}22 
}33 	
private55 
void55 !
Button_ReenviarCorreo55 *
(55* +
object55+ 1
sender552 8
,558 9
RoutedEventArgs55: I
e55J K
)55K L
{55M N

ServidorSE66 
.66 %
AdministradorCuentaClient66 0
cliente661 8
=669 :
new66; >

ServidorSE66? I
.66I J%
AdministradorCuentaClient66J c
(66c d
)66d e
;66e f
cliente77 
.77 
EnviarCorreo77  
(77  !
cuenta77! '
)77' (
;77( )
}88 	
}99 
}:: “
rC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\MenuPrincipal.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
MenuPrincipal &
:' (
Window) /
{0 1
private 

ServidorSE 
. 
Jugador "
jugador# *
;* +
public 
MenuPrincipal 
( 

ServidorSE '
.' (
Jugador( /
jugadorRecibido0 ?
)? @
{A B
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
} 	
private 
void $
Button_ConsultarPuntajes -
(- .
object. 4
sender5 ;
,; <
RoutedEventArgs= L
eM N
)N O
{P Q
ConsultarPuntajes 
ventanaPuntajes -
=. /
new0 3
ConsultarPuntajes4 E
(E F
jugadorF M
)M N
;N O
ventanaPuntajes 
. 
Show  
(  !
)! "
;" #
this 
. 
Close 
( 
) 
; 
} 	
private!! 
void!! 
Button_CerrarSesion!! (
(!!( )
object!!) /
sender!!0 6
,!!6 7
RoutedEventArgs!!8 G
e!!H I
)!!I J
{!!K L

MainWindow"" 
ventanaIncio"" #
=""$ %
new""& )

MainWindow""* 4
(""4 5
)""5 6
;""6 7
ventanaIncio## 
.## 
Show## 
(## 
)## 
;##  
this$$ 
.$$ 
Close$$ 
($$ 
)$$ 
;$$ 
}%% 	
private'' 
void'' 
Button_NuevaPartida'' (
(''( )
object'') /
sender''0 6
,''6 7
RoutedEventArgs''8 G
e''H I
)''I J
{(( 	
CrearPartida)) 
ventanaCrearPartida)) ,
=))- .
new))/ 2
CrearPartida))3 ?
())? @
jugador))@ G
)))G H
;))H I
ventanaCrearPartida** 
.**  
Show**  $
(**$ %
)**% &
;**& '
this++ 
.++ 
Close++ 
(++ 
)++ 
;++ 
},, 	
private.. 
void..  
Button_BuscarPartida.. )
(..) *
object..* 0
sender..1 7
,..7 8
RoutedEventArgs..9 H
e..I J
)..J K
{// 	
BuscarPartida00  
ventanaBuscarPartida00 .
=00/ 0
new001 4
BuscarPartida005 B
(00B C
jugador00C J
)00J K
;00K L 
ventanaBuscarPartida11  
.11  !
Show11! %
(11% &
)11& '
;11' (
this22 
.22 
Close22 
(22 
)22 
;22 
}33 	
}44 
}55 °5
tC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\RegistroUsuario.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
RegistroUsuario (
:) *
Window+ 1
{ 
public 
RegistroUsuario 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Regresar $
($ %
object% +
sender, 2
,2 3
RoutedEventArgs4 C
eD E
)E F
{G H

MainWindow 
ventanaPrincipal '
=( )
new* -

MainWindow. 8
(8 9
)9 :
;: ;
ventanaPrincipal 
. 
Show !
(! "
)" #
;# $
this 
. 
Close 
( 
) 
; 
} 	
private!! 
void!! 
Button_Registrarse!! '
(!!' (
object!!( .
sender!!/ 5
,!!5 6
RoutedEventArgs!!7 F
e!!G H
)!!H I
{!!J K
if"" 
("" 
ValidarCampos"" 
("" 
)"" 
)""  
{## 

ServidorSE$$ 
.$$ %
AdministradorCuentaClient$$ 4
cliente$$5 <
=$$= >
new$$? B

ServidorSE$$C M
.$$M N%
AdministradorCuentaClient$$N g
($$g h
)$$h i
;$$i j

ServidorSE%% 
.%% 
Cuenta%% !
cuenta%%" (
=%%) *
new%%+ .

ServidorSE%%/ 9
.%%9 :
Cuenta%%: @
(%%@ A
)%%A B
{%%C D
Correo%%E K
=%%L M%
textBox_CorreoElectronico%%N g
.%%g h
Text%%h l
,%%l m
Contrase√±a%%n x
=%%y z$
passwordBox_Contrase√±a	%%{ ë
.
%%ë í
Password
%%í ö
}
%%õ ú
;
%%ú ù

ServidorSE&& 
.&& 
Jugador&& "
jugador&&# *
=&&+ ,
new&&- 0

ServidorSE&&1 ;
.&&; <
Jugador&&< C
(&&C D
)&&D E
{&&F G
Apodo&&H M
=&&N O
textBox_Apodo&&P ]
.&&] ^
Text&&^ b
,&&b c
Nombre&&d j
=&&k l"
textBox_NombreUsuario	&&m Ç
.
&&Ç É
Text
&&É á
,
&&á à
	Apellidos
&&â í
=
&&ì î
textBox_Apellidos
&&ï ¶
.
&&¶ ß
Text
&&ß ´
}
&&¨ ≠
;
&&≠ Æ
if'' 
('' 
!'' 
cliente'' 
.'' 
VerificarApodo'' +
(''+ ,
jugador'', 3
)''3 4
)''4 5
{(( 
string)) 
usuarioRepetido)) *
=))+ ,

Properties))- 7
.))7 8
	Resources))8 A
.))A B
usuarioRepetido))B Q
;))Q R

MessageBox** 
.** 
Show** #
(**# $
usuarioRepetido**$ 3
)**3 4
;**4 5
return++ 
;++ 
},, 
if-- 
(-- 
cliente-- 
.-- 
RegistrarJugador-- ,
(--, -
jugador--- 4
,--4 5
cuenta--6 <
)--< =
)--= >
{.. 
cliente// 
.// 
EnviarCorreo// (
(//( )
cuenta//) /
)/// 0
;//0 1
IngresarCodigo00 "
ventanaCodigo00# 0
=001 2
new003 6
IngresarCodigo007 E
(00E F
cuenta00F L
)00L M
;00M N
ventanaCodigo11 !
.11! "
Show11" &
(11& '
)11' (
;11( )
this22 
.22 
Close22 
(22 
)22  
;22  !
}33 
else33 
{44 
string55 
correoRepetido55 )
=55* +

Properties55, 6
.556 7
	Resources557 @
.55@ A
correoRepetido55A O
;55O P

MessageBox66 
.66 
Show66 #
(66# $
correoRepetido66$ 2
)662 3
;663 4
}77 
}88 
}:: 	
private;; 
Boolean;; 
ValidarCampos;; %
(;;% &
);;& '
{;;( )
var<< 
mensaje<< 
=<< 

Properties<< $
.<<$ %
	Resources<<% .
.<<. /
mensajeValidacion<</ @
;<<@ A
if== 
(== !
textBox_NombreUsuario== %
.==% &
Text==& *
====+ -
$str==. 0
||==1 3
textBox_Apellidos==4 E
.==E F
Text==F J
====K M
$str==M O
||==P R
textBox_Apodo==S `
.==` a
Text==a e
====e g
$str==h j
||==k m&
textBox_CorreoElectronico	==n á
.
==á à
Text
==à å
==
==ç è
$str
==è ë
||>> #
passwordBox_Contrase√±a>> )
.>>) *
SecurePassword>>* 8
.>>8 9
Length>>9 ?
==>>@ B
$num>>C D
||>>E G,
 passwordBox_ConfirmarContrase√±a>>H g
.>>g h
SecurePassword>>h v
.>>v w
Length>>w }
==	>>~ Ä
$num
>>Å Ç
)
>>Ç É
{
>>Ñ Ö
string?? 
camposObligatorios?? )
=??* +

Properties??, 6
.??6 7
	Resources??7 @
.??@ A
camposObligatorios??A S
;??S T

MessageBox@@ 
.@@ 
Show@@ 
(@@  
camposObligatorios@@  2
)@@2 3
;@@3 4
returnAA 
falseAA 
;AA 
}BB 
elseCC 
ifCC 
(CC 
!CC #
passwordBox_Contrase√±aCC ,
.CC, -
PasswordCC- 5
.CC5 6
EqualsCC6 <
(CC< =,
 passwordBox_ConfirmarContrase√±aCC= \
.CC\ ]
PasswordCC] e
)CCe f
)CCf g
{DD 
stringEE 
contrase√±aInvalidaEE )
=EE* +

PropertiesEE, 6
.EE6 7
	ResourcesEE7 @
.EE@ A!
contrase√±aNoCoincideEEA U
;EEU V

MessageBoxFF 
.FF 
ShowFF 
(FF  
contrase√±aInvalidaFF  2
)FF2 3
;FF3 4
returnGG 
falseGG 
;GG 
}HH 
returnII 
trueII 
;II 
}JJ 	
}KK 
}LL ÓK
jC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Lobby.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
RegresoMensaje '
:( )

ServidorSE* 4
.4 5&
IAdministradorChatCallback5 O
{ 
private 
Lobby 
lobby 
; 
public 
Lobby 
Lobby 
{ 
get  
=>! #
lobby$ )
;) *
set+ .
=>/ 1
lobby2 7
=8 9
value: ?
;? @
}A B
public 
void 
RecibirMensaje "
(" #
string# )
mensaje* 1
)1 2
{ 	
lobby 
. 
chat 
. 
Add 
( 
mensaje "
)" #
;# $
lobby 
. 
listBox_Chat 
. 
Items $
.$ %
Refresh% ,
(, -
)- .
;. /
} 	
public 
void !
RecibirMensajeMiembro )
() *
Boolean* 1
entrada2 9
,9 :
String; A
apodoB G
)G H
{ 	
if   
(   
entrada   
)   
{!! 
lobby"" 
."" 
chat"" 
."" 
Add"" 
("" 
apodo"" $
+""% &
$str""' *
+""+ ,

Properties""- 7
.""7 8
	Resources""8 A
.""A B
mensajeEntrada""B P
)""P Q
;""Q R
lobby## 
.## 
jugadoresConectados## )
.##) *
Add##* -
(##- .
apodo##. 3
)##3 4
;##4 5
lobby$$ 
.$$ %
label_JugadoresConectados$$ /
.$$/ 0
Content$$0 7
=$$8 9
lobby$$: ?
.$$? @
jugadoresConectados$$@ S
.$$S T
Count$$T Y
+$$Z [

Properties$$\ f
.$$f g
	Resources$$g p
.$$p q 
jugadoresConectados	$$q Ñ
;
$$Ñ Ö
}%% 
else&& 
{'' 
lobby(( 
.(( 
chat(( 
.(( 
Add(( 
((( 
apodo(( $
+((% &
$str((' *
+((+ ,

Properties((- 7
.((7 8
	Resources((8 A
.((A B
mensajeSalida((B O
)((O P
;((P Q
lobby)) 
.)) 
jugadoresConectados)) )
.))) *
Remove))* 0
())0 1
apodo))1 6
)))6 7
;))7 8
lobby** 
.** %
label_JugadoresConectados** /
.**/ 0
Content**0 7
=**8 9
lobby**: ?
.**? @
jugadoresConectados**@ S
.**S T
Count**T Y
+**Z [

Properties**\ f
.**f g
	Resources**g p
.**p q 
jugadoresConectados	**q Ñ
;
**Ñ Ö
}++ 
lobby,, 
.,, 
listBox_Chat,, 
.,, 
Items,, $
.,,$ %
Refresh,,% ,
(,,, -
),,- .
;,,. /
lobby-- 
.-- '
listBox_JugadoresConectados-- -
.--- .
Items--. 3
.--3 4
Refresh--4 ;
(--; <
)--< =
;--= >
}.. 	
}// 
public11 

partial11 
class11 
Lobby11 
:11  
Window11! '
{22 
private33 
int33 

indiceSala33 
;33 
private44 

ServidorSE44 
.44 
Jugador44 "
jugador44# *
;44* +
public55 
List55 
<55 
String55 
>55 
chat55  
=55! "
new55# &
List55' +
<55+ ,
string55, 2
>552 3
(553 4
)554 5
;555 6
InstanceContext66 
contexto66  
;66  !
private77 

ServidorSE77 
.77 #
AdministradorChatClient77 2
servidorChat773 ?
;77? @
public88 
List88 
<88 
String88 
>88 
jugadoresConectados88 /
=880 1
new882 5
List886 :
<88: ;
String88; A
>88A B
(88B C
)88C D
;88D E
public:: 
Lobby:: 
(:: 

ServidorSE:: 
.::  
Jugador::  '
jugadorRecibido::( 7
)::7 8
{;; 	
jugador<< 
=<< 
jugadorRecibido<< %
;<<% &
InitializeComponent== 
(==  
)==  !
;==! "
listBox_Chat>> 
.>> 
ItemsSource>> $
=>>% &
chat>>' +
;>>+ ,'
listBox_JugadoresConectados?? '
.??' (
ItemsSource??( 3
=??4 5
jugadoresConectados??6 I
;??I J
RegresoMensaje@@ 
regresoMensaje@@ )
=@@* +
new@@, /
RegresoMensaje@@0 >
{AA 
LobbyBB 
=BB 
thisBB 
}CC 
;CC 
contextoDD 
=DD 
newDD 
InstanceContextDD *
(DD* +
regresoMensajeDD+ 9
)DD9 :
;DD: ;
servidorChatEE 
=EE 
newEE 

ServidorSEEE )
.EE) *#
AdministradorChatClientEE* A
(EEA B
contextoEEB J
)EEJ K
;EEK L
}FF 	
publicHH 
voidHH 
CrearPartidaHH  
(HH  !

ServidorSEHH! +
.HH+ ,
SalaHH, 0
salaHH1 5
)HH5 6
{II 	

indiceSalaJJ 
=JJ 
servidorChatJJ %
.JJ% &
	CrearSalaJJ& /
(JJ/ 0
salaJJ0 4
)JJ4 5
;JJ5 6
servidorChatKK 
.KK 

UnirseSalaKK #
(KK# $

indiceSalaKK$ .
,KK. /
jugadorKK0 7
)KK7 8
;KK8 9
}LL 	
publicNN 
BooleanNN 
EntrarPartidaNN $
(NN$ %
intNN% (
indiceNN) /
)NN/ 0
{OO 	

indiceSalaPP 
=PP 
indicePP 
;PP  
jugadoresConectadosQQ 
=QQ  !
servidorChatQQ" .
.QQ. /"
ConsultarJugadoresSalaQQ/ E
(QQE F
indiceQQF L
)QQL M
.QQM N
ToListQQN T
(QQT U
)QQU V
;QQV W'
listBox_JugadoresConectadosRR '
.RR' (
ItemsSourceRR( 3
=RR4 5
jugadoresConectadosRR6 I
;RRI J
ifSS 
(SS 
servidorChatSS 
.SS 
ValidarCupoSalaSS ,
(SS, -

indiceSalaSS- 7
)SS7 8
)SS8 9
{TT 
servidorChatUU 
.UU 

UnirseSalaUU '
(UU' (

indiceSalaUU( 2
,UU2 3
jugadorUU4 ;
)UU; <
;UU< =
returnVV 
trueVV 
;VV 
}WW 
returnXX 
falseXX 
;XX 
}YY 	
public[[ 
List[[ 
<[[ 

ServidorSE[[ 
.[[ 
Sala[[ #
>[[# $(
ConsultarPartidasDisponibles[[% A
([[A B
)[[B C
{\\ 	
return]] 
servidorChat]] 
.]]  %
ConsultarSalasDisponibles]]  9
(]]9 :
)]]: ;
.]]; <
ToList]]< B
(]]B C
)]]C D
;]]D E
}^^ 	
private`` 
void`` 
Button_Enviar`` "
(``" #
object``# )
sender``* 0
,``0 1
RoutedEventArgs``2 A
e``B C
)``C D
{aa 	
ifbb 
(bb 
textBox_Mensajebb 
.bb  
Textbb  $
!=bb% '
$strbb( *
)bb* +
{cc 
servidorChatdd 
.dd 
EnviarMensajedd *
(dd* +

indiceSaladd+ 5
,dd5 6
textBox_Mensajedd7 F
.ddF G
TextddG K
)ddK L
;ddL M
textBox_Mensajeee 
.ee  
Clearee  %
(ee% &
)ee& '
;ee' (
}ff 
}gg 	
privateii 
voidii 
CerrarVentanaii "
(ii" #
objectii# )
senderii* 0
,ii0 1
Systemii2 8
.ii8 9
ComponentModelii9 G
.iiG H
CancelEventArgsiiH W
eiiX Y
)iiY Z
{jj 	
servidorChatkk 
.kk 
	SalirChatkk "
(kk" #

indiceSalakk# -
)kk- .
;kk. /
}ll 	
privatenn 
voidnn 
Button_Regresarnn $
(nn$ %
objectnn% +
sendernn, 2
,nn2 3
RoutedEventArgsnn4 C
ennD E
)nnE F
{oo 	
MenuPrincipalpp 
menuPrincipalpp '
=pp( )
newpp* -
MenuPrincipalpp. ;
(pp; <
jugadorpp< C
)ppC D
;ppD E
menuPrincipalqq 
.qq 
Showqq 
(qq 
)qq  
;qq  !
thisrr 
.rr 
Closerr 
(rr 
)rr 
;rr 
}ss 	
}tt 
}uu ”=
rC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\BuscarPartida.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
BuscarPartida &
:' (
Window) /
{ 
private 

ServidorSE 
. 
Jugador "
jugador# *
;* +
private 
Lobby 
lobby 
; 
private 
List 
< 

ServidorSE 
.  
Sala  $
>$ %

listaSalas& 0
;0 1
public 
BuscarPartida 
( 

ServidorSE '
.' (
Jugador( /
jugadorRecibido0 ?
)? @
{ 	
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
lobby 
= 
new 
Lobby 
( 
jugadorRecibido -
)- .
;. /

listaSalas 
= 
lobby 
. (
ConsultarPartidasDisponibles ;
(; <
)< =
;= >
dataGrid_Partidas 
. 
ItemsSource )
=* +

listaSalas, 6
;6 7
} 	
private   
void   
Button_Entrar   "
(  " #
object  # )
sender  * 0
,  0 1
RoutedEventArgs  2 A
e  B C
)  C D
{!! 	
if"" 
("" 
dataGrid_Partidas"" !
.""! "
SelectedItem""" .
==""/ 1
null""2 6
)""6 7
{## 
string$$ 
elegir$$ 
=$$ 

Properties$$  *
.$$* +
	Resources$$+ 4
.$$4 5
elegirPartida$$5 B
;$$B C

MessageBox%% 
.%% 
Show%% 
(%%  
elegir%%  &
)%%& '
;%%' (
return&& 
;&& 
}'' 
if(( 
((( 
!(( 
lobby(( 
.(( 
EntrarPartida(( $
((($ %
dataGrid_Partidas((% 6
.((6 7
SelectedIndex((7 D
)((D E
)((E F
{)) 
string** 
partidaRecurso** %
=**& '

Properties**( 2
.**2 3
	Resources**3 <
.**< =
partida**= D
;**D E
string++ 
llena++ 
=++ 

Properties++ )
.++) *
	Resources++* 3
.++3 4
llena++4 9
;++9 :

ServidorSE,, 
.,, 
Sala,, 
partida,,  '
=,,( )
(,,* +

ServidorSE,,+ 5
.,,5 6
Sala,,6 :
),,: ;
dataGrid_Partidas,,; L
.,,L M
SelectedItem,,M Y
;,,Y Z

MessageBox-- 
.-- 
Show-- 
(--  
partidaRecurso--  .
+--/ 0
partida--1 8
.--8 9
Nombre--9 ?
+--@ A
llena--B G
)--G H
;--H I

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
$str@@6 L
)@@L M
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
$strTT &
)TT& '
{UU 
stringVV 

dobleFichaVV !
=VV" #

PropertiesVV$ .
.VV. /
	ResourcesVV/ 8
.VV8 9

dobleFichaVV9 C
;VVC D
eWW 
.WW 
ColumnWW 
.WW 
HeaderWW 
=WW  !

dobleFichaWW" ,
;WW, -
eXX 
.XX 
ColumnXX 
.XX 
DisplayIndexXX %
=XX& '
$numXX( )
;XX) *
}YY 
ifZZ 
(ZZ 
tituloZZ 
==ZZ 
$strZZ .
)ZZ. /
{[[ 
string\\ 
casillaEspecial\\ &
=\\' (

Properties\\) 3
.\\3 4
	Resources\\4 =
.\\= >
casillaEspecial\\> M
;\\M N
e]] 
.]] 
Column]] 
.]] 
Header]] 
=]]  !
casillaEspecial]]" 1
;]]1 2
e^^ 
.^^ 
Column^^ 
.^^ 
DisplayIndex^^ %
=^^& '
$num^^( )
;^^) *
}__ 
}`` 	
}aa 
}bb ê"
qC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\CrearPartida.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 
CrearPartida %
:& '
Window( .
{ 
private 

ServidorSE 
. 
Jugador "
jugador# *
=+ ,
new- 0

ServidorSE1 ;
.; <
Jugador< C
(C D
)D E
;E F
public 
CrearPartida 
( 

ServidorSE &
.& '
Jugador' .
jugadorRecibido/ >
)> ?
{ 	
jugador 
= 
jugadorRecibido %
;% &
InitializeComponent 
(  
)  !
;! "
} 	
private 
void $
TextBox_Nombre_LostFocus -
(- .
object. 4
sender5 ;
,; <
RoutedEventArgs= L
eM N
)N O
{ 	
if   
(   
textBox_Nombre   
.   
Text   #
==  $ &
$str  ' )
)  ) *
{!! 
label_Nombre"" 
."" 

Visibility"" '
=""( )

Visibility""* 4
.""4 5
Visible""5 <
;""< =
}## 
}$$ 	
private&& 
void&& "
TextBox_Nombre_KeyDown&& +
(&&+ ,
object&&, 2
sender&&3 9
,&&9 :
KeyEventArgs&&; G
e&&H I
)&&I J
{'' 	
label_Nombre(( 
.(( 

Visibility(( #
=(($ %

Visibility((& 0
.((0 1
Hidden((1 7
;((7 8
})) 	
private++ 
void++ "
Label_Nombre_MouseDown++ +
(+++ ,
object++, 2
sender++3 9
,++9 : 
MouseButtonEventArgs++; O
e++P Q
)++Q R
{,, 	
textBox_Nombre-- 
.-- 
Focus--  
(--  !
)--! "
;--" #
}.. 	
private00 
void00 
Button_Regresar00 $
(00$ %
object00% +
sender00, 2
,002 3
RoutedEventArgs004 C
e00D E
)00E F
{11 	
MenuPrincipal22 
menuPrincipal22 '
=22( )
new22* -
MenuPrincipal22. ;
(22; <
jugador22< C
)22C D
;22D E
menuPrincipal33 
.33 
Show33 
(33 
)33  
;33  !
this44 
.44 
Close44 
(44 
)44 
;44 
}55 	
private77 
void77 
Button_CrearPartida77 (
(77( )
object77) /
sender770 6
,776 7
RoutedEventArgs778 G
e77H I
)77I J
{88 	

ServidorSE99 
.99 
Sala99 
sala99  
=99! "
new99# &

ServidorSE99' 1
.991 2
Sala992 6
(996 7
)997 8
{:: 
Nombre;; 
=;; 
textBox_Nombre;; '
.;;' (
Text;;( ,
,;;, -
	DobleDado<< 
=<< 
checkBox_DobleDado<< .
.<<. /
	IsChecked<</ 8
.<<8 9
Value<<9 >
,<<> ?

DobleFicha== 
=== 
checkBox_DobleFicha== 0
.==0 1
	IsChecked==1 :
.==: ;
Value==; @
,==@ A
CasillasEspeciales>> "
=>># $'
checkBox_CasillasEspeciales>>% @
.>>@ A
	IsChecked>>A J
.>>J K
Value>>K P
}?? 
;?? 
Lobby@@ 
lobby@@ 
=@@ 
new@@ 
Lobby@@ #
(@@# $
jugador@@$ +
)@@+ ,
;@@, -
lobbyAA 
.AA 
CrearPartidaAA 
(AA 
salaAA #
)AA# $
;AA$ %
lobbyBB 
.BB 
ShowBB 
(BB 
)BB 
;BB 
thisCC 
.CC 
CloseCC 
(CC 
)CC 
;CC 
}DD 	
}EE 
}FF ú
hC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\App.xaml.cs
	namespace		 	
SerpientesEscaleras		
 
{		 
public 

partial 
class 
App 
: 
Application *
{+ ,
App 
( 
) 
{ 
} 	
} 
} ûP
oC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\MainWindow.xaml.cs
	namespace 	
SerpientesEscaleras
 
{ 
public 

partial 
class 

MainWindow #
:$ %
Window& ,
{ 
public 

MainWindow 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
textBox_Usuario 
. 
Focus !
(! "
)" #
;# $
} 	
private 
void  
Button_IniciarSesion )
() *
object* 0
sender1 7
,7 8
RoutedEventArgs9 H
eI J
)J K
{ 	
String 
correoIngresado "
=# $
textBox_Usuario% 4
.4 5
Text5 9
;9 :
String  
contrase√±aIngresada &
=' (#
passwordBox_contrase√±a) ?
.? @
Password@ H
;H I
if   
(   
!   
ValidarCampos   
(   
)    
)    !
{!! 
return"" 
;"" 
}## 

ServidorSE$$ 
.$$ %
AdministradorCuentaClient$$ 0
cliente$$1 8
=$$9 :
new$$; >

ServidorSE$$? I
.$$I J%
AdministradorCuentaClient$$J c
($$c d
)$$d e
;$$e f

ServidorSE%% 
.%% 
Cuenta%% 
cuenta%% $
=%%% &
new%%' *

ServidorSE%%+ 5
.%%5 6
Cuenta%%6 <
(%%< =
)%%= >
{%%? @
Correo%%A G
=%%H I
correoIngresado%%J Y
,%%Y Z
Contrase√±a%%[ e
=%%f g 
contrase√±aIngresada%%h {
}%%| }
;%%} ~

ServidorSE&& 
.&& 
Jugador&& 
jugador&& &
=&&' (
cliente&&) 0
.&&0 1
IniciarSesion&&1 >
(&&> ?
cuenta&&? E
)&&E F
;&&F G
if'' 
('' 
jugador'' 
!='' 
null'' 
)''  
{(( 
if)) 
()) 
cliente)) 
.)) 
VerificarCuenta)) +
())+ ,
cuenta)), 2
)))2 3
)))3 4
{** 
MenuPrincipal++ !
ventanaPrincipal++" 2
=++3 4
new++5 8
MenuPrincipal++9 F
(++F G
jugador++G N
)++N O
;++O P
ventanaPrincipal,, $
.,,$ %
Show,,% )
(,,) *
),,* +
;,,+ ,
this-- 
.-- 
Close-- 
(-- 
)--  
;--  !
}.. 
else// 
{00 
IngresarCodigo11 "!
ventanaIngresarCodigo11# 8
=119 :
new11; >
IngresarCodigo11? M
(11M N
cuenta11N T
)11T U
;11U V!
ventanaIngresarCodigo22 )
.22) *
Show22* .
(22. /
)22/ 0
;220 1
this33 
.33 
Close33 
(33 
)33  
;33  !
}44 
}55 
else66 
{77 
string88 
datosErroneos88 $
=88% &

Properties88' 1
.881 2
	Resources882 ;
.88; <'
usuarioContrase√±aInvalidas88< V
;88V W

MessageBox99 
.99 
Show99 
(99  
datosErroneos99  -
)99- .
;99. /
}:: 
};; 	
private== 
void== 
Button_Registrarse== '
(==' (
object==( .
sender==/ 5
,==5 6
RoutedEventArgs==7 F
e==G H
)==H I
{>> 	
RegistroUsuario?? 
ventanaRegistro?? +
=??, -
new??. 1
RegistroUsuario??2 A
(??A B
)??B C
;??C D
ventanaRegistro@@ 
.@@ 
Show@@  
(@@  !
)@@! "
;@@" #
thisAA 
.AA 
CloseAA 
(AA 
)AA 
;AA 
}BB 	
privateDD 
voidDD !
CambiarIdiomaEspa√±olDD )
(DD) *
objectDD* 0
senderDD1 7
,DD7 8
RoutedEventArgsDD9 H
eDDI J
)DDJ K
{EE 	
SystemFF 
.FF 
	ThreadingFF 
.FF 
ThreadFF #
.FF# $
CurrentThreadFF$ 1
.FF1 2
CurrentUICultureFF2 B
=FFC D
newFFE H
SystemFFI O
.FFO P
GlobalizationFFP ]
.FF] ^
CultureInfoFF^ i
(FFi j
$strFFj l
)FFl m
;FFm n

MainWindowGG 
loginGG 
=GG 
newGG "

MainWindowGG# -
(GG- .
)GG. /
;GG/ 0
loginHH 
.HH 
ShowHH 
(HH 
)HH 
;HH 
thisII 
.II 
CloseII 
(II 
)II 
;II 
}JJ 	
privateLL 
voidLL 
CambiarIdiomaInglesLL (
(LL( )
objectLL) /
senderLL0 6
,LL6 7
RoutedEventArgsLL8 G
eLLH I
)LLI J
{MM 	
SystemNN 
.NN 
	ThreadingNN 
.NN 
ThreadNN #
.NN# $
CurrentThreadNN$ 1
.NN1 2
CurrentUICultureNN2 B
=NNC D
newNNE H
SystemNNI O
.NNO P
GlobalizationNNP ]
.NN] ^
CultureInfoNN^ i
(NNi j
$strNNj q
)NNq r
;NNr s

MainWindowOO 
loginOO 
=OO 
newOO "

MainWindowOO# -
(OO- .
)OO. /
;OO/ 0
loginPP 
.PP 
ShowPP 
(PP 
)PP 
;PP 
thisQQ 
.QQ 
CloseQQ 
(QQ 
)QQ 
;QQ 
}RR 	
publicSS 
boolSS 
ValidarCamposSS !
(SS! "
)SS" #
{TT 	
ifUU 
(UU 
textBox_UsuarioUU 
.UU  
TextUU  $
==UU% '
$strUU( *
)UU* +
{VV 
stringWW 
ingresaUsuarioWW %
=WW& '

PropertiesWW( 2
.WW2 3
	ResourcesWW3 <
.WW< =
ingresaUsuarioWW= K
;WWK L

MessageBoxXX 
.XX 
ShowXX 
(XX  
ingresaUsuarioXX  .
)XX. /
;XX/ 0
returnYY 
falseYY 
;YY 
}ZZ 
else[[ 
if[[ 
([[ #
passwordBox_contrase√±a[[ +
.[[+ ,
SecurePassword[[, :
.[[: ;
Length[[; A
==[[B D
$num[[E F
)[[F G
{\\ 
string]] 
ingresaContrase√±a]] (
=]]) *

Properties]]+ 5
.]]5 6
	Resources]]6 ?
.]]? @
ingresaContrase√±a]]@ Q
;]]Q R

MessageBox^^ 
.^^ 
Show^^ 
(^^  
ingresaContrase√±a^^  1
)^^1 2
;^^2 3
return__ 
false__ 
;__ 
}`` 
returnaa 
trueaa 
;aa 
}bb 	
privatedd 
voiddd %
TextBox_Usuario_LostFocusdd .
(dd. /
objectdd/ 5
senderdd6 <
,dd< =
RoutedEventArgsdd> M
eddN O
)ddO P
{ee 	
ifff 
(ff 
textBox_Usuarioff 
.ff  
Textff  $
==ff% '
$strff( *
)ff* +
{gg 
label_Usuariohh 
.hh 

Visibilityhh (
=hh) *

Visibilityhh+ 5
.hh5 6
Visiblehh6 =
;hh= >
}ii 
}jj 	
privatell 
voidll -
!PasswordBox_Contrase√±a_LostFocusll 5
(ll5 6
objectll6 <
senderll= C
,llC D
RoutedEventArgsllE T
ellU V
)llV W
{mm 	
ifnn 
(nn #
passwordBox_contrase√±ann &
.nn& '
Passwordnn' /
==nn0 2
$strnn3 5
)nn5 6
{oo 
label_Contrase√±app  
.pp  !

Visibilitypp! +
=pp, -

Visibilitypp. 8
.pp8 9
Visiblepp9 @
;pp@ A
}qq 
}rr 	
privatett 
voidtt 
PasswordBox_KeyDowntt (
(tt( )
objecttt) /
sendertt0 6
,tt6 7
KeyEventArgstt8 D
ettE F
)ttF G
{uu 	
label_Contrase√±avv 
.vv 

Visibilityvv '
=vv( )

Visibilityvv* 4
.vv4 5
Hiddenvv5 ;
;vv; <
}ww 	
privateyy 
voidyy #
TextBox_Usuario_KeyDownyy ,
(yy, -
objectyy- 3
senderyy4 :
,yy: ;
KeyEventArgsyy< H
eyyI J
)yyJ K
{zz 	
label_Usuario{{ 
.{{ 

Visibility{{ $
={{% &

Visibility{{' 1
.{{1 2
Hidden{{2 8
;{{8 9
}|| 	
private~~ 
void~~ '
Label_Contrase√±a_MouseDown~~ /
(~~/ 0
object~~0 6
sender~~7 =
,~~= > 
MouseButtonEventArgs~~? S
e~~T U
)~~U V
{ 	%
passwordBox_contrase√±a
ÄÄ "
.
ÄÄ" #
Focus
ÄÄ# (
(
ÄÄ( )
)
ÄÄ) *
;
ÄÄ* +
}
ÅÅ 	
private
ÉÉ 
void
ÉÉ %
Label_Usuario_MouseDown
ÉÉ ,
(
ÉÉ, -
object
ÉÉ- 3
sender
ÉÉ4 :
,
ÉÉ: ;"
MouseButtonEventArgs
ÉÉ< P
e
ÉÉQ R
)
ÉÉR S
{
ÑÑ 	
textBox_Usuario
ÖÖ 
.
ÖÖ 
Focus
ÖÖ !
(
ÖÖ! "
)
ÖÖ" #
;
ÖÖ# $
}
ÜÜ 	
}
áá 
}ââ æ
wC:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Cliente WPF\SerpientesEscaleras\Properties\AssemblyInfo.cs
[

 
assembly

 	
:

	 

AssemblyTitle

 
(

 
$str

 .
)

. /
]

/ 0
[ 
assembly 	
:	 

AssemblyDescription 
( 
$str !
)! "
]" #
[ 
assembly 	
:	 
!
AssemblyConfiguration  
(  !
$str! #
)# $
]$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str $
)$ %
]% &
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 7
)7 8
]8 9
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
["" 
assembly"" 	
:""	 

	ThemeInfo"" 
("" &
ResourceDictionaryLocation## 
.## 
None## #
,### $&
ResourceDictionaryLocation&& 
.&& 
SourceAssembly&& -
))) 
])) 
[66 
assembly66 	
:66	 

AssemblyVersion66 
(66 
$str66 $
)66$ %
]66% &
[77 
assembly77 	
:77	 

AssemblyFileVersion77 
(77 
$str77 (
)77( )
]77) *