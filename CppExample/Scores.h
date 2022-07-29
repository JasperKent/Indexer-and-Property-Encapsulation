#pragma once

#include<algorithm>
#include<stdexcept>

class Scores
{
private:
	int* const m_scores;
	const int m_count;
	const int m_minScore;
	const int m_maxScore;

public:

	Scores(int count, int minScore, int maxScore)
	: m_scores(new int[count]),
	  m_count(count),
	  m_minScore(minScore),
	  m_maxScore(maxScore)
	{
	}

	int getMaxScore() const
	{
		return *std::max_element(m_scores, m_scores + m_count);
	}

	int operator[](int idx) const
	{
		if (idx < 0 || idx >= m_count)
			throw new std::out_of_range("Index out of range");

		return m_scores[idx];
	}

	int& operator[](int idx)
	{
		if (idx < 0 || idx >= m_count)
			throw std::out_of_range("Index out of range");

		return m_scores[idx];
	}
};

