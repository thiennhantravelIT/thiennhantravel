var homepage=function(){
	var _checkout=function(){
		$("#datepicker-home-chkin").datepicker();
	};
	var _autocomplete=function(){
		$("#search-home-text").click(function(){

			$("#homepage-search-autocomplete").show();
		});
	};
	var _changeautocomplete=function(){
		$("#search-home-text").keyup(function(){

			if($(this).val()!="")
			{
				$("#homepage-search-autocomplete").hide();
			}
			else
			{
				$("#homepage-search-autocomplete").show();
			}
		});
	}
	var _bodyclick=function(){
		$("body").click(function(){
			$("#homepage-search-autocomplete").hide();
		});
	}
return {
	Init:function(){
		_checkout();
		_autocomplete();
		_changeautocomplete();
		//_bodyclick();
	}
}
}();
$(function(){
	homepage.Init();
});