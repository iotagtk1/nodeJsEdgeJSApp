var path = require('path');

process.env.EDGE_USE_CORECLR = 1;
process.env.EDGE_DEBUG=1;
process.env.EDGE_NATIVE='edge-js/build/Release/edge_coreclr.node';

//const baseNetAppPath = path.join(__dirname, '/bin/Release/netstandard2.0/publish/');
//process.env.EDGE_APP_ROOT = baseNetAppPath;

const edge = require('edge-js');

var add7 = edge.func({
    source: path.join(__dirname, '../ConsoleApp1/clsTest.cs') ,
    references: ['System.IO', 'System.Diagnostics.Process']
});

add7('Node.js', function (error, result) {
    if (error) throw error;
    console.log("result   " + result);
});