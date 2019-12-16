function myAlert() {
    alert("C# tan çağırıldı");
}


function alVer(birinciParam, ikinciParam) {
    return "Değerler :" + birinciParam + ikinciParam;
}

function randomRakamVer(limit) {
    DotNet.invokeMethodAsync("BlazorClient.Client", "RandomSayiUret", limit).then(
        result => {
            document.getElementById("randomrakam").innerText = result;
        }
    );
}