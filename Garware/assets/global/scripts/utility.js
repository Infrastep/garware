
if (typeof (utility) === "undefined") {
    utility = {};
}

utility.Querystring = function (name) {

    var match = RegExp('[?&]' + name + '=([^&]*)')
                    .exec(window.location.search);

    return match && decodeURIComponent(match[1].replace(/\+/g, ' '));

}


utility.getCookie = function (c_name) {
    var i, x, y, m, n=null, ARRcookies = document.cookie.split(";");
    for (i = 0; i < ARRcookies.length; i++) {
        x = ARRcookies[i].substr(0, ARRcookies[i].indexOf("="));
        y = ARRcookies[i].substr(ARRcookies[i].indexOf("=") + 1);
        if (x != "") {
            var ARRcookiesVal = y.split("&");
            if (ARRcookiesVal.length > 0) {
                for (j = 0; j < ARRcookiesVal.length; j++) {
                    m = ARRcookiesVal[j].substr(0, ARRcookiesVal[j].indexOf("="));
                    n = ARRcookiesVal[j].substr(ARRcookiesVal[j].indexOf("=") + 1);
                    m = m.replace(/^\s+|\s+$/g, "");
                    if (m == c_name) {
                        return unescape(n);
                        break;
                    }
                    else {
                        n = "";
                        //return n;
                    }
                }

            }
        }
        else {

            x = x.replace(/^\s+|\s+$/g, "");
            if (x == c_name) {
                return unescape(y);
            }
        }
    }
    return unescape(n);
}


utility.ajax = function (urlToHandler, jsonData, async, modal, isdata) {
    var FinalData;
    jQuery.ajax({
        url: urlToHandler,
        data: jsonData,
        dataType: 'json',
        type: 'POST',
        async: async,
        contentType: 'application/json',
        success: function (allData) {

            data = allData;
           
            if (isdata == true)
            { FinalData = data.d; }
            else
            { FinalData = data; }
            if (modal == true) {

                utility.Modal("Ok", data);

            }
            
        },
        error: function (data, status, jqXHR) {
            utility.Error(data, status, jqXHR);
        }
    });

    return FinalData;

}

utility.Error = function (data, status, jqXHR) {

    utility.Modal("Error", 'AJAX Error: ' + jqXHR);

}

utility.PostData = function () {

    var PostData = { Method: null, Type: null, ID: null, Data: null };

    return PostData
}


utility.Modal = function (type, message, Json) {

    var icon
    var divclass


    switch (type) {

        case 'Error':
            divclass = 'error';
            icon = 'url';
            break;
        case 'Ok':
            divclass = 'ok';
            //icon = 'url'; //Commented on 26.06.12
            break;
        case 'basket':
            divclass = 'ok';
            icon = '../img/prod_basket.png'; //Commented on 26.06.12
            break;
        case 'Expected delivery date':
            divclass = 'Expected delivery date';
            //            icon = '../img/prod_basket.png'; //Commented on 26.06.12
            break;
        default:
            divclass = 'info';
            icon = 'url';

    }


    //initialization code

//    $.gritter.add({
//        // (string | mandatory) the heading of the notification
//        title: divclass,
//        // (string | mandatory) the text inside the notification
//        text: message,
//        // (string | optional) the image to display on the left
//        image: icon,
//        // (bool | optional) if you want it to fade out on its own or just sit there
//        sticky: false,
//        // (int | optional) the time you want it to be alive for before fading out
//        time: 4000,
//        class_name: 'bottom-right'
//    });

    return false;




}

utility.IsEmail = function (email) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}
var dateFormat = function () {
    var token = /d{1,4}|m{1,4}|yy(?:yy)?|([HhMsTt])\1?|[LloSZ]|"[^"]*"|'[^']*'/g,
        timezone = /\b(?:[PMCEA][SDP]T|(?:Pacific|Mountain|Central|Eastern|Atlantic) (?:Standard|Daylight|Prevailing) Time|(?:GMT|UTC)(?:[-+]\d{4})?)\b/g,
        timezoneClip = /[^-+\dA-Z]/g,
        pad = function (val, len) {
            val = String(val);
            len = len || 2;
            while (val.length < len) val = "0" + val;
            return val;
        };

    // Regexes and supporting functions are cached through closure
    return function (date, mask, utc) {
        var dF = dateFormat;

        // You can't provide utc if you skip other args (use the "UTC:" mask prefix)
        if (arguments.length == 1 && Object.prototype.toString.call(date) == "[object String]" && !/\d/.test(date)) {
            mask = date;
            date = undefined;
        }

        // Passing date through Date applies Date.parse, if necessary
        date = date ? new Date(date) : new Date;
        if (isNaN(date)) throw SyntaxError("invalid date");

        mask = String(dF.masks[mask] || mask || dF.masks["default"]);

        // Allow setting the utc argument via the mask
        if (mask.slice(0, 4) == "UTC:") {
            mask = mask.slice(4);
            utc = true;
        }

        var _ = utc ? "getUTC" : "get",
            d = date[_ + "Date"](),
            D = date[_ + "Day"](),
            m = date[_ + "Month"](),
            y = date[_ + "FullYear"](),
            H = date[_ + "Hours"](),
            M = date[_ + "Minutes"](),
            s = date[_ + "Seconds"](),
            L = date[_ + "Milliseconds"](),
            o = utc ? 0 : date.getTimezoneOffset(),
            flags = {
                d: d,
                dd: pad(d),
                ddd: dF.i18n.dayNames[D],
                dddd: dF.i18n.dayNames[D + 7],
                m: m + 1,
                mm: pad(m + 1),
                mmm: dF.i18n.monthNames[m],
                mmmm: dF.i18n.monthNames[m + 12],
                yy: String(y).slice(2),
                yyyy: y,
                h: H % 12 || 12,
                hh: pad(H % 12 || 12),
                H: H,
                HH: pad(H),
                M: M,
                MM: pad(M),
                s: s,
                ss: pad(s),
                l: pad(L, 3),
                L: pad(L > 99 ? Math.round(L / 10) : L),
                t: H < 12 ? "a" : "p",
                tt: H < 12 ? "am" : "pm",
                T: H < 12 ? "A" : "P",
                TT: H < 12 ? "AM" : "PM",
                Z: utc ? "UTC" : (String(date).match(timezone) || [""]).pop().replace(timezoneClip, ""),
                o: (o > 0 ? "-" : "+") + pad(Math.floor(Math.abs(o) / 60) * 100 + Math.abs(o) % 60, 4),
                S: ["th", "st", "nd", "rd"][d % 10 > 3 ? 0 : (d % 100 - d % 10 != 10) * d % 10]
            };

        return mask.replace(token, function ($0) {
            return $0 in flags ? flags[$0] : $0.slice(1, $0.length - 1);
        });
    };
} ();

// Some common format strings
dateFormat.masks = {
    "default": "ddd mmm dd yyyy HH:MM:ss",
    shortDate: "m/d/yy",
    mediumDate: "mmm d, yyyy",
    longDate: "mmmm d, yyyy",
    fullDate: "dddd, mmmm d, yyyy",
    shortTime: "h:MM TT",
    mediumTime: "h:MM:ss TT",
    longTime: "h:MM:ss TT Z",
    isoDate: "yyyy-mm-dd",
    isoTime: "HH:MM:ss",
    isoDateTime: "yyyy-mm-dd'T'HH:MM:ss",
    isoUtcDateTime: "UTC:yyyy-mm-dd'T'HH:MM:ss'Z'"
};

// Internationalization strings
dateFormat.i18n = {
    dayNames: [
        "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat",
        "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
    ],
    monthNames: [
        "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec",
        "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
    ]
};

// For convenience...
Date.prototype.format = function (mask, utc) {
    return dateFormat(this, mask, utc);
};

utility.loadScript = function (url, callback) {

    var script = document.createElement("script")
    script.type = "text/javascript";

    if (script.readyState) {  //IE
        script.onreadystatechange = function () {
            if (script.readyState == "loaded" ||
                    script.readyState == "complete") {
                script.onreadystatechange = null;
                callback();
            }
        };
    } else {  //Others
        script.onload = function () {
            callback();
        };
    }

    script.src = url;
    document.getElementsByTagName("head")[0].appendChild(script);
}


function mmsg(title, msg) {

 
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-bottom-right",
            "preventDuplicates": true,
            "onclick": null,
            "showDuration": "5000",
            "hideDuration": "5000",
            "timeOut": "5000",
            "extendedTimeOut": "5000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
    
    


       
          var $toast = toastr[title](msg); // Wire up an event handler to a button in the toast, if it exists
        
    $toastlast = $toast;


}




utility.growl = function (text) {
    $.bootstrapGrowl(text, {
        ele: 'body', // which element to append to
        type: 'success', // (null, 'info', 'danger', 'success', 'warning')
        offset: {
            from: 'bottom',
            amount: 100
        }, // 'top', or 'bottom'
        align: 'right', // ('left', 'right', or 'center')
        width: 'auto', // (integer, or 'auto')
        delay: 5, // Time while the message will be displayed. It's not equivalent to the demo timeOut!
        allow_dismiss: true, // If true then will display a cross to close the popup.
        stackup_spacing: 10 // spacing between consecutively stacked growls.
    });
}