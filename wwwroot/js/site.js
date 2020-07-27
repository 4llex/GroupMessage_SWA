// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.

//Listen for new group
// When a new group is created, we will call the reloadGroup() function. To listen for events, we need to initialize Pusher’s Javascript library.
let currentGroupId = null;

var pusher = new Pusher('09532d1997ef71999f27', {
    cluster: 'us2',
    encrypted: true
});

var channel = pusher.subscribe('group_chat');

channel.bind('new_group', function(data) {
    reloadGroup();
});


// -------------------------------------------------

//Create a group by making an AJAX request to /api/group using a POST method.
$("#CreateNewGroupButton").click(function(){
    // get all selected users
    let UserNames = $("input[name='UserName[]']:checked")
                    .map(function(){return $(this).val();}).get();
    
    let data = { 
                GroupName: $("#GroupName").val(),
                UserNames: UserNames
        };
        
    $.ajax({
        type: "POST",
        url: "/api/group",
        data: JSON.stringify(data),
        success: (data) => {
            reloadGroup();
            $('#CreateNewGroup').modal('hide');
        },
        dataType: 'json',
        contentType:'application/json'
    });
    
});


// When a user clicks on a group, we’ll make a request to get all messages in that group. Add the following code to wwwroot/js/site.js:
// When a user clicks on a group, Load messages for that particular group.
$(".group").click( function(){
    let group_id = $(this).attr("data-group_id");

    $('.group').css({"border-style": "none", cursor:"pointer"});
    $(this).css({"border-style": "inset", cursor:"default"});

    $("#currentGroup").val(group_id); // update the current group_id to a html form...
    currentGroupId =  group_id;
    
    // get all messages for the group and populate it...
    $.get( "/api/message/"+group_id, function( data ) {
        let message = "";
        
        data.forEach(function(data){
                let position = ( data.addedBy == $("#UserName").val() ) ? " float-right" : "";
                message += `<div class="row chat_message` + position +`"><b>`+ data.addedBy +`: </b>`+ data.message +` </div>`;
        });
        
        $(".chat_body").html(message);
    });
    
   pusher.unsubscribe('private-'+group_id); //unsubscribe

   let group_channel = pusher.subscribe('private-'+group_id);
     
   group_channel.bind('new_message', function(data) { 

        if( currentGroupId == data.new_message.GroupId){

             $(".chat_body").append(`<div class="row chat_message"><b>`+ data.new_message.AddedBy +`: </b>`+ data.new_message.message +` </div>`);
        }
     });  

});

//Display the new group when a user creates a group
//When a new group is created, we will reload the groups for every user.Add the following function to
function reloadGroup(){
    $.get("/api/group", function( data ) {
        let groups = "";
               console.log(data); 
       data.forEach(function(group){
           groups += `<div class="group" data-group_id="` +group.groupId+ `">` +group.groupName+  `</div>`;
       });
       
       $("#groups").html(groups);
    });
}


//Add new message via Ajax
//When a user clicks on the send message button, we’ll make an AJAX call to the method we added... 
//above with the message payload so it gets saved in the database.
$("#SendMessage").click( function(){
    
    $.ajax({
        type: "POST",
        url: "/api/message",
        data: JSON.stringify( {
            AddedBy: $("#UserName").val(), 
            GroupId: $("#currentGroup").val(), 
            message: $("#Message").val(), 
            socketId: pusher.connection.socket_id
        }),
        success: (data) => { 
            console.log(data);
            $(".chat_body").append(`<div class="row chat_message float-right"><b>`+ data.data.addedBy +`: </b>`+ $("#Message").val() +` </div>`);
            $("#Message").val('');
        },
        dataType: 'json',
        contentType:'application/json'
    });
});