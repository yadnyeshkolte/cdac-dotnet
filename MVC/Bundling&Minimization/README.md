Step 1 Code In wwwroot/css/Style2.css
---------------------------------
section {
    padding: 20px;
    margin: 20px 0;
}

/* Classes for buttons */
.btn {
    display: inline-block;
    background: #555;
    color: #fff;
    padding: 10px 15px;
    margin: 5px 0;
    text-decoration: none;
    border-radius: 5px;
    transition: background 0.3s;
}
---------------------------------------
Step 2 Code In wwwroot/css/Mystyles.css
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, sans-serif;
    line-height: 1.6;
    color: #333;
    background-color: #f4f4f4;
}

header {
    background: #333;
    color: #fff;
    padding: 1rem 0;
    text-align: center;
}

Step 3 Code In Views/Shared/LayOutView To Call These Css files
----------------------------------------------------------------
<link href="~/css/Style2.css
.css" rel="stylesheet" />
    <link href="~/css/Mystyles.css
.css" rel="stylesheet" />
-------------------------------------------------------------------
Step 4 Install Package BuildBundlerMinifier With Help 
of Nuget Package Managet
----------------------------------------------------------------------
Step 5  Create a Bundle Configuration File
-------------------------------------------------------
Create a file named bundleconfig.json in the root  of your project By Clicking on Solution Name. This file defines the bundling and minification settings when we used the BuildBundlerMinifier package.

Code In bundleconfig.json File
---------------------------------------
[
  
  {
    "outputFileName": "wwwroot/css/MySite.min.css",
    "inputFiles": [
      "wwwroot/css/*.css"
    ],
    "minify": {
      "enabled": true,
      "renameLocals": true
    },
    "includeInProject": false
  }
]
-------------------------------------------------------------
Step 6 Remove Code of Step 3 From Layout view
and Add Following Code And Run Project

<link href="~/css/MySite.min.css" rel="stylesheet" />
