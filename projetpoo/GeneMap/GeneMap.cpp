// Il s'agit du fichier DLL principal.

#include "stdafx.h"
#include "GeneMap.h"

GeneMapG::GeneMap::GeneMap(int s){
	size = s;
	random = 0;
}


void GeneMapG::GeneMap::randomFillTest(){
	srand(time(NULL));
	random = rand();
}

void GeneMapG::GeneMap::randomFill(){

}