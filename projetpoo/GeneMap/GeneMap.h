// GeneMap.h

#pragma once

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
		void randomFill();
	};
}
