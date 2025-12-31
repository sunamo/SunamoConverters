// EN: Script to delete empty .cs files (only comments and empty classes)
// CZ: Skript pro smazání prázdných .cs souborů (jen komentáře a prázdné třídy)

const fs = require('fs');
const path = require('path');

const rootDir = path.join(__dirname, '..');
const dryRun = !process.argv.includes('--execute');

// EN: Check if file is empty (only comments and empty class/interface/struct)
// CZ: Zkontroluje, zda je soubor prázdný (jen komentáře a prázdná třída/interface/struct)
function isEmptyFile(filePath) {
  const content = fs.readFileSync(filePath, 'utf8');

  // EN: Remove all comments
  // CZ: Odstraní všechny komentáře
  let cleanedContent = content
    .replace(/\/\/.*$/gm, '') // single-line comments
    .replace(/\/\*[\s\S]*?\*\//g, '') // multi-line comments
    .replace(/^\s*$/gm, ''); // empty lines

  // EN: Remove using directives
  // CZ: Odstraní using directives
  cleanedContent = cleanedContent.replace(/using\s+[^;]+;/g, '');

  // EN: Remove namespace declarations (but keep the content inside)
  // CZ: Odstraní namespace deklarace (ale nechá obsah uvnitř)
  cleanedContent = cleanedContent.replace(/namespace\s+[^;{]+[;{]/g, '');

  // EN: Remove all whitespace
  // CZ: Odstraní všechny mezery
  cleanedContent = cleanedContent.replace(/\s+/g, '');

  // EN: After removing everything, only empty class/interface/struct should remain: {}
  // CZ: Po odstranění všeho by měla zbýt jen prázdná třída/interface/struct: {}
  // Also check for class/interface/struct Name{} pattern
  const emptyClassPattern = /^(internal|public|private|protected)?(class|interface|struct|enum)[a-zA-Z0-9_]*\{\}?$/;
  const justBraces = /^\{\}?$/;

  return justBraces.test(cleanedContent) || emptyClassPattern.test(cleanedContent) || cleanedContent === '';
}

// EN: Find all .cs files recursively
// CZ: Najde všechny .cs soubory rekurzivně
function findCsFiles(dir, fileList = []) {
  const files = fs.readdirSync(dir);

  files.forEach(file => {
    const filePath = path.join(dir, file);
    const stat = fs.statSync(filePath);

    if (stat.isDirectory()) {
      // Skip node_modules, bin, obj folders
      if (!['node_modules', 'bin', 'obj', 'scripts'].includes(file)) {
        findCsFiles(filePath, fileList);
      }
    } else if (file.endsWith('.cs')) {
      fileList.push(filePath);
    }
  });

  return fileList;
}

// EN: Main function
// CZ: Hlavní funkce
function main() {
  console.log('EN: Finding all .cs files...');
  console.log('CZ: Hledání všech .cs souborů...\n');

  const allCsFiles = findCsFiles(rootDir);
  console.log(`EN: Found ${allCsFiles.length} .cs files`);
  console.log(`CZ: Nalezeno ${allCsFiles.length} .cs souborů\n`);

  const emptyFiles = [];

  allCsFiles.forEach(filePath => {
    if (isEmptyFile(filePath)) {
      emptyFiles.push(filePath);
    }
  });

  if (emptyFiles.length === 0) {
    console.log('EN: No empty files found');
    console.log('CZ: Nenalezeny žádné prázdné soubory');
    return;
  }

  console.log(`EN: Found ${emptyFiles.length} empty files:`);
  console.log(`CZ: Nalezeno ${emptyFiles.length} prázdných souborů:\n`);

  emptyFiles.forEach(file => {
    const relativePath = path.relative(rootDir, file);
    console.log(`  - ${relativePath}`);
  });

  if (dryRun) {
    console.log('\nEN: DRY RUN - files were NOT deleted. Run with --execute to delete them.');
    console.log('CZ: ZKUŠEBNÍ BĚŽENÍ - soubory NEBYLY smazány. Spusť s --execute pro smazání.');
  } else {
    console.log('\nEN: Deleting files...');
    console.log('CZ: Mazání souborů...\n');

    emptyFiles.forEach(file => {
      fs.unlinkSync(file);
      const relativePath = path.relative(rootDir, file);
      console.log(`  ✓ Deleted: ${relativePath}`);
    });

    console.log(`\nEN: Successfully deleted ${emptyFiles.length} files`);
    console.log(`CZ: Úspěšně smazáno ${emptyFiles.length} souborů`);
  }
}

main();
