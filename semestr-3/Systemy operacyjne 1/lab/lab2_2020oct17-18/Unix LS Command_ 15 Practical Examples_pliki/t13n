
(function() {
function onLoad() {
if (!google.elements || !google.elements.inputtools) {
return;
}
var t13nDivId = 't13nc-cse-search-box';
if (document.getElementById(t13nDivId)) {
return;
}
var t13nLangs = 'en'.split(',');
var validT13nLangs = [];
var inputToolCodeNS = google.elements.inputtools.InputToolCode;
for (var i in t13nLangs) {
if (!t13nLangs[i]) continue;
var t13nLangCode = t13nLangs[i] + '-t-i0-und';
if (t13nLangCode === 'zh-t-i0-und') {
validT13nLangs.push('zh-t-i0-pinyin');
} else if (t13nLangCode == 'zh_hant-t-i0-und') {
validT13nLangs.push('zh-hant-t-i0-und');
} else {
for (var langEnum in inputToolCodeNS) {
if (t13nLangCode === inputToolCodeNS[langEnum]) {
validT13nLangs.push(t13nLangCode);
}
}
}
}
if (validT13nLangs.length > 0) {
var f = document.getElementById('cse-search-box');
if (!f) {
f = document.getElementById('searchbox_demo');
}
if (f && f['q']) {
var wrapperTable = document.createElement('table');
f.parentNode.appendChild(wrapperTable);
var tbody = document.createElement('tbody');
var tr = document.createElement('tr')
var td1 = document.createElement('td');
var t13ncDiv = document.createElement('div');
t13ncDiv.id = t13nDivId;
td1.appendChild(t13ncDiv);
var td2 = document.createElement('td');
td2.appendChild(f);
tr.appendChild(td1);
tr.appendChild(td2);
tbody.appendChild(tr);
wrapperTable.appendChild(tbody);
var css = document.createElement("style");
css.type = "text/css";
var content =
'a.ita-kd-icon-button.small {height:24px; width:24px; min-width:24px;} ' +
'a.ita-kd-icon-button.dropdown {height:24px; width:14px; min-width:14px;}';
if (css.styleSheet) {
css.styleSheet.cssText = content;
} else {
var textNode = document.createTextNode(content);
css.appendChild(textNode);
}
document.getElementsByTagName('head')[0].appendChild(css);
f['q'].setAttribute('goog_input_bookmarklet', '1');
var controller = new google.elements.inputtools.InputToolsController();
controller.setApplicationName("cse");
controller.addPageElements(f['q']);
controller.addInputTools(validT13nLangs);
controller.showControl({container: t13nDivId});
controller.activateInputTool(validT13nLangs[0]);
}
}
}
google.load("elements", "1", {packages: "inputtools", "callback": onLoad});
})();
