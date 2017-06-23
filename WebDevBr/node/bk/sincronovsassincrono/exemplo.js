var fs = require('fs');

fs.readFile('resources/file.pdf',function(err,data){
	console.log('async',data);
});

var data = fs.readFileSync('resources/file.pdf');
console.log('sync',data);
