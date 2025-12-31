// EN: Debug script to see what remains after cleaning
// CZ: Debug skript pro zobrazení toho, co zbyde po čištění

const fs = require('fs');
const path = require('path');

const filePath = process.argv[2];

if (!filePath) {
  console.log('Usage: node debug-cs-file.js <file-path>');
  process.exit(1);
}

const content = fs.readFileSync(filePath, 'utf8');

console.log('=== ORIGINAL CONTENT ===');
console.log(content);
console.log('\n=== STEP 1: Remove single-line comments ===');
let step1 = content.replace(/\/\/.*$/gm, '');
console.log(step1);

console.log('\n=== STEP 2: Remove multi-line comments ===');
let step2 = step1.replace(/\/\*[\s\S]*?\*\//g, '');
console.log(step2);

console.log('\n=== STEP 3: Remove empty lines ===');
let step3 = step2.replace(/^\s*$/gm, '');
console.log(step3);

console.log('\n=== STEP 4: Remove using directives ===');
let step4 = step3.replace(/using\s+[^;]+;/g, '');
console.log(step4);

console.log('\n=== STEP 5: Remove namespace declarations ===');
let step5 = step4.replace(/namespace\s+[^;{]+[;{]/g, '');
console.log(step5);

console.log('\n=== STEP 6: Remove all whitespace ===');
let step6 = step5.replace(/\s+/g, '');
console.log(step6);

console.log('\n=== CHECKING PATTERNS ===');
const emptyClassPattern = /^(internal|public|private|protected)?(class|interface|struct|enum)[a-zA-Z0-9_]*\{\}?$/;
const justBraces = /^\{\}?$/;

console.log('Matches emptyClassPattern:', emptyClassPattern.test(step6));
console.log('Matches justBraces:', justBraces.test(step6));
console.log('Is empty string:', step6 === '');
