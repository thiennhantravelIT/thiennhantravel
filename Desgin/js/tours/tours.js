jQuery(document).ready(function($){
    var nowTemp = new Date();
    var now = new Date(nowTemp.getFullYear(), nowTemp.getMonth(), nowTemp.getDate(), 0, 0, 0, 0);
    var checkin = $('#arrival').datepicker({
        format:'dd/mm/yyyy',
        onRender: function(date) {
            return date.valueOf() < now.valueOf() ? 'disabled' : '';
        }
    }).on('changeDate',function(ev){
        $('.datepicker').hide();
    });
    ////==========//////
    $('.quick-view li').click(function(){
            $('.quick-view li').removeClass('active');
        var scr = $(this).attr('id');
        $('html,body').animate({ scrollTop: $('.'+scr).offset().top },'500');
        $(this).addClass('active');
    });
    //===========//
    wd = $(window).width();
    if(wd<800){
        $('.sidebar-detail').insertAfter('.single-tour-info');
    }
    //=============//
    $(window).scroll(function(){
        if($(this).scrollTop() > 200 && wd >800 ){
            $('.excerpt-tour').addClass('fixp');
            var h = $('.single-tour').height();
            if($(this).scrollTop() > h-420){
                $('.excerpt-tour').removeClass('fixp');
            }
        }
        if($(this).scrollTop() < 200 ){
            $('.excerpt-tour').removeClass('fixp');
        }
        //---//
        $('.single-tour-content div.scr').each(function(){
            var id = $(this).attr('id'), t = $('#'+id).offset().top, h = $('#'+id).outerHeight(), wh = $(window).height(), ws = $(window).scrollTop();
            if(ws > (t+h-wh)){
                $('.quick-view li').removeClass('active');
                $('#'+id+'ctr').addClass('active');
            }
        });

    });
    //==============//
    $('.dktab li').click(function(){
        $('.dktab li').removeClass('dkactive');
        $(this).addClass('dkactive');
        id = $(this).attr('data-id');
        $('#baogom, #khongbaogom, #phuthu').css({'display':'none'});
        $('#'+id).stop().fadeIn(500);
    });
    //===============//
    $('#type-search').on('click',function(){ 
        data = '<div class="respdata"><li><i class="glyphicon glyphicon-map-marker"></i><strong> Địa điểm</strong></li><li><a href="#">Đà Lạt</a></li><li><a href="#">Nha Trang</a></li><li><a href="#">Vũng tàu</a></li><li><a href="#">Đà Nẵng</a></li><li><a href="#">Phan Thiết</a></li><li><a href="#">Hạ Long</a></li></div>';
        data1 = '<div class="respdata"><li><i class="glyphicon glyphicon-map-marker"></i><strong> Địa điểm</strong></li><li><a href="#">Đà Lạt</a></li><li><a href="#">Nha Trang</a></li><li><a href="#">Vũng tàu</a></li><li><a href="#">Đà Nẵng</a></li><li><a href="#">Phan Thiết</a></li><li><a href="#">Hạ Long</a></li><li><i class="glyphicon glyphicon-tree-deciduous"></i><strong> Tours</strong></li><li><a href="#">Tours nội thành Đà Lạt</a></li><li><a href="#">Tour Đà Lạt - Nha Trang 2 ngày 1 đêm</a></li></div>';
        if($(this).val() == ''){
            $('.search-form').append(data);
        }
        if($(this).val() != ''){
            $('.search-form').append(data1);
        }
        $('#type-search').on('input',function(e){
            if($(this).data('lastval')!= $(this).val()){
                $(this).data('lastval',$(this).val());
                var qr = $(this).val();
                if(qr != ''){
                    $('.search-form').append(data1);
                }else{
                    if(qr == ''){
                        $('.respdata').remove();
                        $('.search-form').append(data);
                    }
                }
            }
        });
    });
    $('#type-search').on('blur',function(){
        $('.respdata').remove();
    });
});