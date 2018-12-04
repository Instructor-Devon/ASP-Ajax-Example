$("form").submit(function(e){
    let dataObj = $(this).serialize();
    e.preventDefault();
    $.ajax({
        url: "http://localhost:5000/process",
        method: "POST",
        data: dataObj,
    })
    .done(function(data){
        console.log(data);
    })
})