function setCookie(key,val){
    tmp = key+"="+escape(val)+";";
    tmp += "; path=/; expires=Fri, 31-Dec-2030 23:59:59;";
    document.cookie = tmp;
}

function getCookie(key){
    tmp = document.cookie+";";
    tmp1 = tmp.indexOf(key,0);
    if(tmp1 != -1){
        tmp = tmp.substring(tmp1,tmp.length);
        start = tmp.indexOf("=",0) +1 ;
        end = tmp.indexOf(";",start);
        return(unescape(tmp.substring(start,end)));
    }
    return("");
}

function delCookie(key){
if(window.confirm("全て削除します。よろしいですか？")){
    expiredate = new Date();
    expiredate.setYear(expiredate.getYear()-1);
    tmp = key+"=;";
    tmp += "; path=/; expires="+expiredate.toGMTString();
    document.cookie = tmp;
   
	delid = document.getElementById("listall");
	delid.style.display = "none";
	}
}

function delEachCookie(id){
if(window.confirm("１件削除します。よろしいですか？")){
	//delword = "/," + id + "/g";
	re = new RegExp(","+id, "g");
	//alert(re);
	tmpcookie = getCookie("kword");
	tmpcookie = tmpcookie.replace(re, "");
	setCookie("kword",tmpcookie);

	
	delid = document.getElementById(id);
	delid.style.display = "none";
	}
}

function setColor(name){
    //alert('気になる求人リストに追加します');
    kword = getCookie("kword");
    //alert(kword);
    name = kword + ',' + name;
    setCookie("kword",name);
        alert('追加しました\nメニュー右上の”追加した求人リスト”をクリックすると\n一括で求人応募が出来ます');
        //alert(getCookie("kword"));
}

function allcheck() {
	//alert("allcheck");
	var form_name = 'id[]';
	var count = document.form.elements[form_name].length;
	var allcheck = document.form.chk_all.checked;

	console.log("count:" + count);
	if(count == undefined){
			if (allcheck == true) {
				document.form.elements[form_name].checked = true;
				document.form.chk_all2.checked = true;
			} else {
				document.form.elements[form_name].checked = false;
				document.form.chk_all2.checked = false;
			}
	}else{
		for ( var i=0; i<count; i++) {
			var check = document.form.elements[form_name][i].checked;
			console.log("check:" + check);
			if (allcheck == true) {
				document.form.elements[form_name][i].checked = true;
				document.form.chk_all2.checked = true;
			} else {
				document.form.elements[form_name][i].checked = false;
				document.form.chk_all2.checked = false;
			}
		}
	}
}
function allcheck2() {
	var form_name = 'id[]';
	var count = document.form.elements[form_name].length;
	var allcheck = document.form.chk_all2.checked;
	
	console.log("count:" + count);	
	if(count == undefined){
			if (allcheck == true) {
				document.form.elements[form_name].checked = true;
				document.form.chk_all.checked = true;
			} else {
				document.form.elements[form_name].checked = false;
				document.form.chk_all.checked = false;
			}
	}else{
		for ( var i=0; i<count; i++) {
			var check = document.form.elements[form_name].checked;

			if (allcheck == true) {
				document.form.elements[form_name][i].checked = true;
				document.form.chk_all.checked = true;
			} else {
				document.form.elements[form_name][i].checked = false;
				document.form.chk_all.checked = false;
			}
		}
	}
}

