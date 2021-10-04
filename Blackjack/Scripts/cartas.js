function carta(symbol, suit, score, color, lista) {
    //alert('Symbol: ' + symbol + ' Suit: ' + suit + ' Score: ' + score + ' Color: ' + color);

    switch (suit) {
        case 'picas':
            suit = '&spades;'
            break;
        case 'trebol':
            suit = '&clubs;'
            break;
        case 'corazones':
            suit = '&hearts;'
            break;
        case 'diamantes':
            suit = '&diams;'
            break;
        default:
            break;
    };

    switch (color) {
        case 'Negro':
            color = ''
            break;
        case 'Rojo':
            color = 'red'
            break;

        default:
            break;
    };
    let item;
    switch (symbol) {
        case '10':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotA2">' + suit + '</div>\
                                <div class="spotA4">' + suit + '</div>\
                                <div class="spotA5">' + suit + '</div>\
                                <div class="spotB2">' + suit + '</div>\
                            \
                                <div class="spotB4">' + suit + '</div>\
                                <div class="spotC1">' + suit + '</div>\
                                <div class="spotC2">' + suit + '</div>\
                                <div class="spotC4">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case '9':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotA2">' + suit + '</div>\
                                <div class="spotA4">' + suit + '</div>\
                                <div class="spotA5">' + suit + '</div>\
                                <div class="spotB3">' + suit + '</div>\
                                <div class="spotC1">' + suit + '</div>\
                                <div class="spotC2">' + suit + '</div>\
                \
                                <div class="spotC4">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case '8':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotA3">' + suit + '</div>\
                \
                                <div class="spotA5">' + suit + '</div>\
                                <div class="spotB2">' + suit + '</div>\
                                <div class="spotB4">' + suit + '</div>\
                                <div class="spotC1">' + suit + '</div>\
                                <div class="spotC3">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;

        case '7':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotA3">' + suit + '</div>\
                                <div class="spotA5">' + suit + '</div>\
                                <div class="spotB2">' + suit + '</div>\
                                <div class="spotC1">' + suit + '</div>\
                                <div class="spotC3">' + suit + '</div>\
                \
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case '6':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotA3">' + suit + '</div>\
                                <div class="spotA5">' + suit + '</div>\
                            \
                                <div class="spotC1">' + suit + '</div>\
                                <div class="spotC3">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case '5':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="spotA1">' + suit + '</div>\
                \
                                <div class="spotA5">' + suit + '</div>\
                                <div class="spotB3">' + suit + '</div>\
                                <div class="spotC1">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case '4':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                \
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotA5">' + suit + '</div>\
                                <div class="spotC1">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case '3':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                \
                                <div class="spotB1">' + suit + '</div>\
                                <div class="spotB3">' + suit + '</div>\
                                <div class="spotB5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case '2':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="spotB1">' + suit + '</div>\
                            \
                                <div class="spotB5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case 'A':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <div class="ace">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case 'K':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <img class="face" src="/graphics/king.gif" alt width="80" />\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case 'Q':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <img class="face" src="/graphics/queen.gif" alt width="80" />\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        case 'J':
            item = '<div class="card" > \
                            <div class="front ' + color + '">\
                                <div class="index">' + symbol + '<br />' + suit + '</div>\
                                <img class="face" src="/graphics/jack.gif" alt width="80" />\
                                <div class="spotA1">' + suit + '</div>\
                                <div class="spotC5">' + suit + '</div>\
                            </div>\
                        </div>';
            break;
        default:
            break;
    }

    $(lista).append('<li>' + item + '</li>');

}