!function(e,t){"object"==typeof exports&&"undefined"!=typeof module?module.exports=t():"function"==typeof define&&define.amd?define(t):((e=e||self).__vee_validate_locale__hu=e.__vee_validate_locale__hu||{},e.__vee_validate_locale__hu.js=t())}(this,function(){"use strict";var e,t={name:"hu",messages:{_default:function(e){return"A(z) ${field} értéke nem megfelelő."},after:function(e,t){return"A(z) "+e+" legalább "+t[0]+" utáni dátum kell, hogy legyen."},alpha:function(e){return"A(z) "+e+" kizárólag betűket tartalmazhat."},alpha_dash:function(e){return"A(z) "+e+" kizárólag betűket, számokat, kötőjeleket és alulvonásokat tartalmazhat."},alpha_num:function(e){return"A(z) "+e+" kizárólag betűket és számokat tartalmazhat."},alpha_spaces:function(e){return"A(z) "+e+" kizárólag betűket és szóközöket tartalmazhat."},before:function(e,t){return"A(z) "+e+" legalább "+t[0]+" előtti dátum kell, hogy legyen."},between:function(e,t){return"A(z) "+e+" "+t[0]+" és "+t[1]+" között kell, hogy legyen."},confirmed:function(e){return"A(z) "+e+" nem egyezik a megerősítéssel."},credit_card:function(e){return"A(z) "+e+" nem érvényes."},date_between:function(e,t){return"A(z) "+e+" "+t[0]+" és "+t[1]+" közötti dátum kell, hogy legyen."},date_format:function(e,t){return"A(z) "+e+" nem egyezik az alábbi dátum formátummal "+t[0]+"."},decimal:function(e,t){void 0===t&&(t=[]);var n=t[0];return void 0===n&&(n="*"),"The "+e+" must be numeric and may contain "+("*"===n?"":n)+" decimal points."},digits:function(e,t){return"A(z) "+e+" "+t[0]+" számjegyű kell, hogy legyen."},dimensions:function(e,t){return"A(z) "+e+" felbontása "+t[0]+" és "+t[1]+" pixel között kell, hogy legyen."},email:function(e){return"A(z) "+e+" nem érvényes email formátum."},excluded:function(e){return"A(z) "+e+" értéke érvénytelen."},ext:function(e){return"A(z) "+e+" nem érvényes fájl."},image:function(e){return"A(z) "+e+" képfálj kell, hogy legyen."},included:function(e){return"A kiválaszott "+e+" érvénytelen."},ip:function(e){return"A(z) "+e+" érvényes IP cím kell, hogy legyen."},max:function(e,t){return"A(z) "+e+" értéke nem lehet hosszabb mint "+t[0]+"."},max_value:function(e,t){return"A(z) "+e+" értéke "+t[0]+" vagy kevesebb lehet."},mimes:function(e){return"A(z) "+e+" kizárólag érvényes fájlformátumok egyike lehet."},min:function(e,t){return"A(z) "+e+" értéke nem lehet rövidebb mint "+t[0]+"."},min_value:function(e,t){return"A(z) "+e+" értéke "+t[0]+" vagy több lehet."},numeric:function(e){return"A(z) "+e+" értéke szám kell, hogy legyen."},regex:function(e){return"A(z) "+e+" formátuma érvénytelen."},required:function(e){return"A(z) "+e+" megadása kötelező."},size:function(e,t){return"A(z) "+e+" méretének "+t[0]+" kilobájtnál kisebbnek kell lennie."},url:function(e){return"A(z) "+e+" érvénytelen link."}},attributes:{}};return"undefined"!=typeof VeeValidate&&VeeValidate.Validator.localize(((e={})[t.name]=t,e)),t});