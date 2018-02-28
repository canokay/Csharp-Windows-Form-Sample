# TextBox KeyPress Control
## Sayı KeyPress
```
if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//Eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//Eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//Bunların dışındaysa hiçbirisini yazdırma
            }
```

## Sayı KeyPress
```
if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = true;//Eğer rakamsa  yazdırma.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//Eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = false;//Bunların dışındaysa yazdır
            }
```


<img src="https://resmim.net/f/uqrzj2.jpg" />
