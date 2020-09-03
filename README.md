# Hanoi Tower

Algorytm rozwiązujący [Wieżę Hanoi](https://pl.wikipedia.org/wiki/Wieże_Hanoi) o zadanej wysokości w optymalnej ilości ruchów, wykorzystując metodę binarną.

## Metoda binarna

Metoda binarna polega na zapisaniu numeru wykonywanego ruchu w systemie binarnym i sprawdzaniu który bit (licząc od prawej stony) naszej liczby zmienił się z zera na 1.<br/>

Na przykład:
- W pierwszym ruchu zwiększa się pierwszy bit ***0*** >>> ***1***
- W drugim ruchu zwiększa się drugi bit ***1*** >>> ***10***
- W trzecim ruchu znowu zwiększa się pierwszy bit ***11***

Każdy bit odpowiada elementowi wieży. Licząc od prawej, pierwszy bit to najmniejszy element, drugi bit to drugi najmniejszy element i tak aż do największego elementu wieży.<br/>

Bit którego zmianę zaobserwowaliśmy sygnalizuje, który element wieży należy przenieść. Metoda binarna nigdy nie wskazuje elementu, którego przeniesienie byłoby w tym momencie ruchem nielegalnym. Jeżeli całkowita liczba elementów wieży jest parzysta, należy przenieść element na najbliższy stos po prawej, a jeżeli to niemożliwe to należy go przenieść o dwa stosy w prawo. Jeżeli całkowita liczba elementów jest nieparzysta, należy dany element przenieść na najbliższy stos po lewej, a jeżeli to niemożliwe to o dwa stosy w lewo.

Przykład:<br/>
<br/>

***Stos trzyelementowy***

1<br/>
2<br/>
3<br/>
<br/>
W pierwszym ruchu należy przenieść pierwszy element w lewo<br/>    
<br/>
2<br/>
3       1<br/>
<br/>
W drugim ruchu należy przenieść drugi element w lewo, ale nie można go położyć na pierwszym elemencie, więc przenosimy go o dwa pola w lewo.<br/>
<br/>
3   2   1<br/>
<br/>
W trzecim ruchu znowu należy przenieść pierwszy element w lewo<br/>
<br/>
    1<br/>
3   2<br/>
<br/>
W czwartym ruchu należy przenieść trzeci element<br/>
    1<br/>
    2   3<br/>
<br/>
W piątym ruchu znowu należy przenieść pierwszy element w lewo<br/>
<br/>
1   2   3<br/>
<br/>
W szóstym ruchu należy przenieść drugi element w lewo, ale ponownie nie można go położyć na elemencie pierwszym, więc przenosimy go o dwa pola w lewo.<br/>
<br/>
        2<br/>
1       3<br/>
<br/>
W ostatnim ruchu należy przenieść pierwszy element o jedno pole w lewo<br/>
<br/>
        1<br/>
        2<br/>
        3<br/>
<br/>

***Jest to optymalna liczba ruchów, wyrażona wzorem 2^n - 1***<br/>
Analogicznie należy postępować z dowolną liczbą elementów, biorąc pod uwagę, czy jest to liczba parzysta, czy nieparzysta.

## Program

Program najpierw tworzy trzy Stosy (Stack), ***A***, ***B***, oraz ***C***, po czym wypełnia stos ***A*** liczbą elementów zadaną przez użytkownika. Stos ***B*** oraz ***C*** na razie są pozostawione puste. Następnie program rysuje stos A, po czym czeka 100ms i wchodzi w pętlę, z której nie wyjdzie dopóki stos ***C*** nie będzie wyglądał tak samo, jak początkowy stos ***A***.<br/>

### Pętla while

Na początku pętli program sprawdza jaki ruch został wykonany poprzednio (na początku jest to 0), oraz jaki ruch zostanie wykonany następny. Liczby te zamienia na liczby binarne. Po czym porównuje który bit zmienił się z ***0*** na ***1***<br/>
Następnie sprawdzane jest to, czy liczba elementów jest parzysta, czy nieparzysta, oraz który Stos ma  na szczycie element, który należy przenieść. Program sprawdza, na który ze stosów powinien przenieść dany element, po czym wykonuje ten ruch.<br/>

Na końcu pętli stosy są rysowane przez program, a stos ***C*** porównywany jest do początkowego stanu stosu ***A***, jeżeli zostanie zwrócona wartość ***true***, pętla jest przerywana, a program końćzy swoje działanie. Jeżeli zwrócona zostanie wartość ***false***, program poczeka 100ms (aby użytkownik był w stanie obserwować zmiany) i pętla rozpocznie się na nowo.


