var hubUrl = 'http://localhost:44331/chat';

//Object.defineProperty(WebSocket, 'OPEN', { value: 1, });

let hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/chat")
    .configureLogging(signalR.LogLevel.Information)
    .build();

hubConnection.on("Send", function (data) {

    let elem = document.createElement("p");
    elem.appendChild(document.createTextNode(data));
    let firstElem = document.getElementById("chatroom").firstChild;
    document.getElementById("chatroom").insertBefore(elem, firstElem);

});

document.getElementById("sendBtn").addEventListener("click", function (e) {
    let message = document.getElementById("message").value;
    hubConnection.invoke("Send", message);
});

/*async function sync() {
    await hubConnection.start().then(() => {
        console.log("signalR connection");
    }).catch(function (err) {
        //failed to connect
        return console.error(err.toString());
    });
}

sync();*/

hubConnection.start().then(function () {
    document.getElementById("sendBtn").disabled = false;
    console.log("SignalR already connected");
}).catch(function (err) {
    return console.log("error");
});