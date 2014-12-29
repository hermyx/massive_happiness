// GeneMap.h

#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

using namespace System;

namespace GeneMapG {

	public ref class GeneMap
	{
	private:
		int size;
		int random;
		int** matrix;

	public:
		GeneMap(int); //s for size
		void randomFillTest();
		void randomFill();
	};
}
