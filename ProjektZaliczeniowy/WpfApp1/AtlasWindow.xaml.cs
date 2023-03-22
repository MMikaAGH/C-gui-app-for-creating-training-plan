using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProjektZaliczeniowy;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy AtlasWindow.xaml
    /// </summary>
    public partial class AtlasWindow : Window
    {
        AtlasCw atlas = new AtlasCw();
        public AtlasWindow()
        {
            InitializeComponent();
            atlas = (AtlasCw)AtlasCw.OdczytajXML("Atlas_Cwiczen");
            if (atlas is object)
                lstKat.ItemsSource = new ObservableCollection<Cwiczenie>(atlas.Atlas);
        }

        private void btnWybierz_Click(object sander,RoutedEventArgs e)
        {
            if (lstKat.SelectedIndex == 0)
                txtOpis.Text = "Stań prosto. Złap sztangę podchwytem, rozstawiając dłonie nieco szerzej niż na szerokość barków." +
                    " Sztanga powinna swobodnie spoczywać w Twoich dłoniach na wysokości bioder. W pierwszej fazie ruchu unieś ciężar" +
                    " wzdłuż tułowia do wysokości klatki piersiowej, zginając i prowadząc łokcie za sobą. Przy tym ćwiczeniu pracują stawy: " +
                    "łokciowy i barkowy. W drugiej fazie ruchu opuść ciężar, cały czas kontrolując jego ruch. To pozwoli na przedłużenie napięcia mięśni dwugłowych.";
            if (lstKat.SelectedIndex == 1)
                txtOpis.Text = "1) Pozycja stojąca, plecy wyprostowane. Nogi rozstawione na szerokość bioder zapewniają stabilną postawę." +
                    "2) Unieś ramiona tak, aby hantle znajdowały się na wysokości głowy/barków." +
                    "n3) Palce zwrócone do przodu. Łokcie w jednej linii z nadgarstkami.";
            if (lstKat.SelectedIndex == 2)
                txtOpis.Text = "Stań prosto w lekkim rozkroku, hantle trzymając po bokach. Możesz delikatnie ugiąć łokcie." +
                    " Unieś hantle szeroko na boki, aż Twoje ręce znajdą się w pozycji równoległej do podłoża albo wyżej – aż " +
                    "hantle znajdą się na wysokości uszu. Wróć do startu.";
            if (lstKat.SelectedIndex == 3)
                txtOpis.Text = "Stań prosto w lekkim rozkroku, hantle trzymając po bokach. Możesz delikatnie ugiąć łokcie. " +
                    "Unieś hantle szeroko na boki, aż Twoje ręce znajdą się w pozycji równoległej do podłoża albo wyżej – " +
                    "aż hantle znajdą się na wysokości uszu. Wróć do startu.";
            if (lstKat.SelectedIndex == 4)
                txtOpis.Text = "1) Utrzymując prawidłową pozycję wyjściową i unikając kołysania tułowiem, wykonaj wdech i wznoś hantle w przód, aż ramiona będą ustawione równolegle do podłogi." +
                    "2) Wykonaj wydech, po czym opuść ramiona." +
                    "3) Wykonaj wyznaczoną liczbę powtórzeń.";
            if (lstKat.SelectedIndex == 5)
                txtOpis.Text = "1) Utrzymując prawidłową pozycję wyjściową, wykonaj wdech." +
                    "2) Rozpocznij uginanie z jednoczesną rotacją zewnętrzną (supinacją), aby finalnie dłoń była skierowana kciukiem na zewnątrz." +
                    "3) Zatrzymaj ruch na ułamek sekundy w pozycji końcowej.\r\n4) Z wydechem wykonaj ruch opuszczania znacznie wolniej niż podnoszenia, wracając do neutralnej pozycji ramion.";
            if (lstKat.SelectedIndex == 6)
                txtOpis.Text = "Stań stabilnie twarzą do wyciągu uginając delikatnie stawy kolanowe. Chwyć linki wyciągu górnego chwytem zamkniętym." +
                    " Wykonaj dynamiczny ruch koncentryczny, czyli wyprost przedramion. Pamiętaj, aby utrzymywać łokcie jak najbliżej tułowia";
            if (lstKat.SelectedIndex == 7)
                txtOpis.Text = "Zaciśnij palce na gryfie mocno, ale bez przesady, bo zmęczysz dłonie, zanim wykonasz ćwiczenie. Stań prosto, stopy rozstawiając na szerokość barków." +
                    " Nogi lekko ugnij w kolanach. Pamiętaj, by nie zmieniać kąta ugięcia podczas ćwiczenia, bo skończy się to bujaniem w przód i w tył";
            if (lstKat.SelectedIndex == 8)
                txtOpis.Text = "1) Weź wdech, utrzymując prawidłową pozycję wyjściową, wykonaj mocne ugięcie ramion w łokciach ze sztangą do momentu szczytowego napięcia bicepsa, w którym sztanga powinna znajdować się na wysokości barków. Utrzymaj stałe napięcie mięśni." +
                    "n2) Utrzymaj maksymalnie napięty biceps przez ułamek sekundy, w szczytowym momencie ruchu wykonaj wydech, a następnie powolnym ruchem opuść przedramiona." +
                    "n3) Wykonaj wyznaczoną liczbę powtórzeń.";
            if (lstKat.SelectedIndex == 9)
                txtOpis.Text = "Między udami a kolanami powinien być kąt prosty. Głowa, tułów i uda powinny tworzyć linię prostą. Dłonie położone na potylicy, nie splecione. Z wydechem zrób brzuszek aż " +
                    "odczujesz maksymalne spięcie mięśni brzucha, a następnie z wdechem wyprostuj tułów wracając do pozycji wyjściowej.";
            if (lstKat.SelectedIndex == 10)
                txtOpis.Text = "Oprzyj obręcz o jeden bok i delikatnym ruchem rąk wpraw ją w ruch. Od razu poruszaj biodrami, starając się utrzymać hula-hoop na wysokości pasa. Nie przejmuj się, że na początku będzie spadało po kilku obrotach. " +
                    "Chwila wytrwałości wystarczy, że bez przerwy kręcić nawet po kilkanaście minut";
            if (lstKat.SelectedIndex == 11)
                txtOpis.Text = "Zacznij uginać kolana, jednocześnie wypychając biodra do tyłu, do momentu aż uda znajdą się w pozycji co najmniej równoległej do podłoża. Zatrzymaj na chwilę ruch, po czym wróć do pozycji początkowej. " +
                    "Podczas wykonywania przysiadu klasycznego pamiętaj, by stopy całe przylegały do podłogi.";
            if (lstKat.SelectedIndex == 12)
                txtOpis.Text = "1) Symulując pedałowanie na rowerze, wyprostuj prawą nogę, jednocześnie przyciągnij lewe kolano do prawego łokcia i skręć tułów tak, aby możliwe było wykonanie ruchu. Wykonaj wydech. " +
                    "2) Przez ułamek sekundy zatrzymaj ruch w maksymalnym napięciu mięśni brzucha." +
                    " 3) Wróć do pozycji wyjściowej, wykonaj płynny wdech";
            if (lstKat.SelectedIndex == 13)
                txtOpis.Text = "Wystarczy z pozycji leżącej podnieść ciężar ciała na przedramionach, trzymając łokcie równo pod barkami i opierając wyprostowane ciało na palcach stóp przy jednoczesnym napięciu wszystkich mięśni. " +
                    "Nazwa plank zrodziła się z porównania ułożenia ciała do nieruchomej deski";
            if (lstKat.SelectedIndex == 14)
                txtOpis.Text = "1) Podpór bokiem na przedramieniu, ramię ugięte pod kątem 90 stopni, górna część prostopadle do podłoża. Kończyny dolne złączone, wyprostowane, w jednej linii z tułowiem i ułożone równolegle do podłoża." +
                    "2) Plecy proste. Wzrok skierowany w przód." +
                    "3) Mięśnie brzucha mocno napięte.";
            if (lstKat.SelectedIndex == 15)
                txtOpis.Text = "Przysiad to ćwiczenie, w którym opuszczamy biodra z pozycji stojącej w dół, jednocześnie zginając nogi w kolanach. Ponadto, ćwiczenie to jest jednym z najbardziej naturalnych ruchów człowieka, nie jest skomplikowane," +
                    " a do jego wykonania wystarczy kawałek równej przestrzeni";
            if (lstKat.SelectedIndex == 16)
                txtOpis.Text = "Stopy są cały przy podłożu i stabilizują pozycję. Ściągnij łopatki i wyeksponuj klatkę piersiową. Wykonaj dynamiczny ruch koncentryczny, czyli wypchnięcie hantli nad głowę, unikaj przeprostów w stawach łokciowych." +
                    " Następnie wykonaj powolny ruch ekscentryczny, czyli opuszczenie hantli delikatnie poniżej linii uszu";
            if (lstKat.SelectedIndex == 17)
                txtOpis.Text = "Pompka (właśc.: uginanie i prostowanie ramion w podporze przodem) – popularna nazwa ćwiczenia fizycznego wykonywanego w pozycji poziomej, twarzą do ziemi, polegającego na podnoszeniu i obniżaniu tułowia.";
            if (lstKat.SelectedIndex == 18)
                txtOpis.Text = "Rozpiętki przy użyciu obojętnie jakich narzędzi treningowych to ćwiczenie izolowane rozciągające mięśnie klatki piersiowej. Podczas ruchu klatka piersiowa jest mocno spinana i rozciągana. Jest to znakomite ćwiczenie, które może pełnić funkcję rozgrzewki, przed treningiem klatki piersiowej.";
            if (lstKat.SelectedIndex == 19)
                txtOpis.Text = "Stopy są cały przy podłożu i stabilizują pozycję. Ściągnij łopatki i wyeksponuj klatkę piersiową. Wykonaj dynamiczny ruch koncentryczny, czyli wypchnięcie hantli nad głowę, unikaj przeprostów w stawach łokciowych. Następnie wykonaj powolny ruch ekscentryczny, czyli opuszczenie hantli delikatnie poniżej linii uszu";
            if (lstKat.SelectedIndex == 20)
                txtOpis.Text = "Bierzemy wdech i opuszczamy sztangę do środkowej części klatki piersiowej (nieco powyżej linii sutków), ramiona nie powinny rozchodzić się na boki. W momencie kiedy gryf sztangi dotknie klatki piersiowej, wyciskamy (wypychamy) ją z powrotem do pozycji wyjściowej, robiąc w końcowej fazie ruchu wydech.";
            if (lstKat.SelectedIndex == 21)
                txtOpis.Text = "1. Pozycja startowa: Rozpocznij ćwiczenie od pozycji stojącej z lekko ugiętymi nogami w stawach kolanowych i rękoma zgiętymi w stawach łokciowych, uniesionymi na wysokości klatki piersiowej ze splecionymi dłońmi." +
                    "2. Następnie zejdź nogami w dół robiąc półprzysiad i wykonaj dynamiczne odbicie z obu nóg podciągając kolana na wysokość klatki piersiowej, próbując dotknąć dłoni." +
                    "3. Podskocz tak wysoko jak to tylko możliwe, a następnie wyląduj bezpiecznie na obie nogi, amortyzując lądowanie lekkim ugięciem w stawach kolanowych. Powtórz podskoki klika razy. Ilość powtórzeń ćwiczenia (sugerowane 10-15) jest uzależniona on twojego programu treningowego.";
            if (lstKat.SelectedIndex == 22)
                txtOpis.Text = "Polega na biegu z utrzymywaniem nóg sztywno wyprostowanych w kolanach, a jego celem jest zwiększenie siły, z jaką wyrzucana jest noga do przodu. Zadanie dynamicznego odbicia stóp od podłoża spoczywa niemal wyłącznie na stawach skokowych i łydkach. Ręce podczas skipu D pracują jak podczas zwykłego biegu";
            if (lstKat.SelectedIndex == 23)
                txtOpis.Text = "Postaraj się osiągnąc maksymalną prędkość w jak najszybszym czasie. Pmaiętaj o dynamice ";
            if (lstKat.SelectedIndex == 24)
                txtOpis.Text = "Stań twarzą do skrzyni ze sztangą opartą na górze pleców. Wejdź prawą nogą na skrzynię, dźwignij się do góry, dostaw drugą nogę. Zejdź, powtórz. W połowie serii rozpocznij wejścia na skrzynię drugą nogą.";
            if (lstKat.SelectedIndex == 25)
                txtOpis.Text = "1) Z pozycji, w której stopa jest mocno zadarta do góry, pięta skrajnie obniżona, palce skierowane w górę, a łydka mocno rozciągnięta, odepchnij się od podwyższenia poprzez mocne wspięcie na palce i napięcie łydek." +
                    "2) Po krótkim przytrzymaniu w maksymalnym napięciu łydki opuść pięty do poziomu palców, ponownie rozciągnij łydkę i wykonaj wydech." +
                    "3) Wykonaj wyznaczoną liczbę powtórzeń.";
            if (lstKat.SelectedIndex == 26)
                txtOpis.Text = "1) Pozycja siedząca, nogi ugięte w kolanach, sztanga ustawiona na mięśniach czworogłowych, tuż nad stawem kolanowym.]" +
                    "2) Przednia część stóp na podwyższeniu. Pięty opuszczone, kostki w pasywnym zgięciu.";
            if (lstKat.SelectedIndex == 27)
                txtOpis.Text = "Twoje nogi powinny być ugięte w kolanach do kąta prostego, a kolana nie powinny wykraczać poza linię palców stóp. Złap uchwyty, dociśnij plecy do oparcia, a następnie zwolnij blokadę." +
                    " Wyprostuj nogi, zatrzymaj na ułamek sekundy ruch i wróć do pozycji startowej.";
            if (lstKat.SelectedIndex == 28)
                txtOpis.Text = "Stoisz prosto, ręce są ugięte w łokciach, a obciążenie znajduje się w dłoni. Trzymasz hantle przed sobą prostopadle do podłogi, a więc ramiona oraz przedramiona tworzą kąt prosty." +
                    " Obracasz nadgarstki do środka i na boki przez pół minuty.";
            if (lstKat.SelectedIndex == 29)
                txtOpis.Text = "1) Utrzymując prawidłową pozycję wyjściową, weź wdech i wykonaj dokładne płynne zgięcie przedramion w pełnym zakresie ruchu. " +
                    "2) Utrzymaj maksymalnie napięty biceps przez ułamek sekundy. " +
                    "3) Następnie powolnym ruchem opuść przedramiona do pełnego rozciągnięcia, wykonaj również płynny wydech";
            if (lstKat.SelectedIndex == 30)
                txtOpis.Text = "1) Utrzymując prawidłową pozycję wyjściową, weź wdech i wykonaj dokładne płynne zgięcie przedramion w pełnym zakresie ruchu." +
                    " 2) Utrzymaj maksymalnie napięty biceps przez ułamek sekundy." +
                    " 3) Następnie powolnym ruchem opuść przedramiona do pełnego rozciągnięcia, wykonaj również płynny wydech";
            if (lstKat.SelectedIndex == 31)
                txtOpis.Text = "Chwyć krzesło w dłonie przed sobą na wysokości miednicy. Z tej pozycji unieś je powoli w wyprostowanych ramionach, nieco wyżej niż linia barków. Następnie powoli wróć do pozycji wyjściowej. " +
                    "Staraj się nie wykonywać żadnych ruchów tułowiem w trakcie ćwiczenia.";
            if (lstKat.SelectedIndex == 32)
                txtOpis.Text = "Należy zacząć od tego, że drążek musi wisieć na odpowiedniej wysokości, by móc wisieć na nim bez podkurczania nóg. Zwis robi się nachwytem, ręce ustawiają się na szerokości barków. " +
                    "Podczas wykonywania ćwiczenia mięśnie powinny być rozluźnione, ponieważ celem ćwiczenia jest odprężenie.";
            if (lstKat.SelectedIndex == 33)
                txtOpis.Text = "Chwyć drążki chwytem neutralnym, czyli z czterema palcami skierowanymi na zewnątrz. Podkurcz nogi, by nie dotykały podłoża. Ręce utrzymuj jak najbliżej tułowia. Wyprostuj ramiona w stawach " +
                    "łokciowych i wykonaj wydech.";
            if (lstKat.SelectedIndex == 34)
                txtOpis.Text = "Chwyć drążki chwytem neutralnym, czyli z czterema palcami skierowanymi na zewnątrz. Podkurcz nogi, by nie dotykały podłoża. Ręce utrzymuj jak najbliżej tułowia. Wyprostuj ramiona w stawach łokciowych i wykona";
            if (lstKat.SelectedIndex == 35)
                txtOpis.Text = "chwyć uchwyt wyciągu górnego podchwytem, chwytem zamkniętym. ugnij delikatnie stawy kolanowe, ściągnij łopatki i wyeksponuj klatkę piersiową. wykonaj dynamiczny ruch koncentryczny, czyli wyprost przedramienia. " +
                    "następnie wykonaj powolny ruch ekscentryczny, czyli ugięcie przedramienia.";
            if (lstKat.SelectedIndex == 36)
                txtOpis.Text = "Przyjmij pozycję w leżeniu na ławce poziomej. Unieś hantle do góry na wyprostowanych przedramionach. W pozycji początkowej kciuki dłoni powinny być skierowane do siebie równolegle. Wykonaj powolny ruch ekscentryczny, " +
                    "czyli ugięcie przedramion, opuszczając hantle na wysokość uszu.";
            if (lstKat.SelectedIndex == 37)
                txtOpis.Text = "Przyjmij pozycję w leżeniu na ławce poziomej. Unieś hantle do góry na wyprostowanych przedramionach. W pozycji początkowej kciuki dłoni powinny być skierowane do siebie równolegle. Wykonaj powolny ruch ekscentryczny, czyli ugięcie przedramion, opuszczając hantle na wysokość uszu";
            if (lstKat.SelectedIndex == 38)
                txtOpis.Text = "Ustaw biodro w pozycji neutralnej. Z wdechem wykonaj przysiad do skrzyni tak, aby dotknąć ją pośladkami. Cofnij biodra i ugnij kolana, zachowując wyprostowaną postawę. Wstań do pozycji wyjściowej i wykonując wdech napnij mięśnie brzucha i pośladk";
            if (lstKat.SelectedIndex == 39)
                txtOpis.Text = "Stopy rozstaw na szerokość bioder, wyprostuj plecy, tak by były w jednej linii z głową, wciągnij brzuch, zaś ramiona razem z dłońmi wyciągnij wyprostowane przed siebie. Zacznij uginać kolana, jednocześnie wypychając biodra do tyłu, do momentu aż uda znajdą się w pozycji co najmniej równoległej do podłoża.";
            if (lstKat.SelectedIndex == 40)
                txtOpis.Text = "Umieść palce u rąk pod sztangą, nieco szerzej niż na szerokość barków i unieś łokcie do góry. Trzymając brzuch napięty i klatkę piersiową wypchniętą do przodu, zegnij biodra i kolana do momentu, w którym uda będą w pozycji równoległej do podłogi. Następnie, wyprostuj biodra i kolana wracając do pozycji wyjściowej.";
            if (lstKat.SelectedIndex == 41)
                txtOpis.Text = "Chwyć sztangę nachwytem, chwytem zamkniętym i połóż ją na karku. Wykonaj powolny wykrok jednej nogi i ugnij nogi w stawach kolanowych. Następnie wykonaj dynamiczny powrót do pozycji wyjściowej. Wykroki wykonuj naprzemiennie.";
        }
    }
   }
