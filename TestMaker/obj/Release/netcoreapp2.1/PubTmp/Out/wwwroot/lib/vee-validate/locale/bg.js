!function(n,e){"object"==typeof exports&&"undefined"!=typeof module?module.exports=e():"function"==typeof define&&define.amd?define(e):((n=n||self).__vee_validate_locale__bg=n.__vee_validate_locale__bg||{},n.__vee_validate_locale__bg.js=e())}(this,function(){"use strict";var n,e={name:"bg",messages:{_default:function(n){return"Полето "+n+" е с невалидна стойност."},alpha:function(n){return"Полето "+n+" може да съдържа само азбучни знаци."},alpha_dash:function(n){return"Полето "+n+" може да съдържа буквено-цифрови знаци, както и тирета и долни черти."},alpha_num:function(n){return"Полето "+n+" може да съдържа само буквено-цифрови символи."},alpha_spaces:function(n){return"Полето "+n+" може да съдържа само азбучни знаци, както и интервали."},between:function(n,e){return"Полето "+n+" може да е между "+e[0]+" и "+e[1]+"."},confirmed:function(n){return"Потвърждението не съвпада за полето "+n+"."},credit_card:function(n){return"Полето "+n+" е навалидно."},decimal:function(n,e){void 0===e&&(e=[]);var t=e[0];return void 0===t&&(t="*"),"Полето "+n+" трябва да е числено "+(t&&"*"!==t?"и може да съдържа ${decimals} знака":"")},digits:function(n,e){return"Полето "+n+" трябва да е цифрово и да съдържа точно "+e[0]+" цифри."},dimensions:function(n,e){return"Полето "+n+" трябва да е "+e[0]+" пиксела по "+e[1]+" пиксела."},email:function(n){return"Полето "+n+" трябва да е коректен Email адрес."},excluded:function(n){return"Полето "+n+" трябва да е с валидна стойност."},ext:function(n){return"Полето "+n+" трябва да е валиден файл."},image:function(n){return"Полето "+n+" трябва да е снимка."},included:function(n){return"Полето "+n+" трябва да е валидна стойност."},integer:function(n){return"Полето "+n+" трябва да е цяло число."},ip:function(n){return"Полето "+n+" трябва да е валиден IP адрес."},length:function(n,e){var t=e[0],r=e[1];return r?"Полето "+n+" трябва да е с дължина между "+t+" и "+r+" знака.":"Полето "+n+" трябва да е с дължилна "+t+" знака."},max:function(n,e){return"Полето "+n+" не може да бъде по-голямо от "+e[0]+" знака."},max_value:function(n,e){return"Полето "+n+" трябва да бъде "+e[0]+" или по-малко."},mimes:function(n){return"Полето "+n+" трябва да е валиден тип файл."},min:function(n,e){return"Полето "+n+" трябва да съдържа минимум "+e[0]+" символа."},min_value:function(n,e){return"Полето "+n+" трябва да бъде минимум "+e[0]+" или повече."},numeric:function(n){return"Полето "+n+" може да съдържа само цифри."},regex:function(n){return"Полето "+n+" съдържа невалиден формат."},required:function(n){return"Полето "+n+" е задължително."},size:function(n,e){var t,r,u,i=e[0];return"Размерът на файла за полето "+n+" трябва да е под "+(t=i,r=1024,u=0==(t=Number(t)*r)?0:Math.floor(Math.log(t)/Math.log(r)),1*(t/Math.pow(r,u)).toFixed(2)+" "+["Byte","KB","MB","GB","TB","PB","EB","ZB","YB"][u])+"."},url:function(n){return"Полето "+n+" не съдържа валиден URL адрес."}},attributes:{}};return"undefined"!=typeof VeeValidate&&VeeValidate.Validator.localize(((n={})[e.name]=e,n)),e});