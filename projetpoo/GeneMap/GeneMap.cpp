// Il s'agit du fichier DLL principal.

#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include "stdafx.h"
#include "GeneMap.h"

GeneMapG::GeneMap::GeneMap(int s){
	this->size = s;
	this->randomFill = 0;
}


void GeneMapG::GeneMap::randomFill(){
	srand(time(NULL));
	this->randomFill = rand();
}

int main(){
	int i = 3;
	GeneMapG::GeneMap::GeneMap *Gege;
	Gege = new GeneMap(i);
}