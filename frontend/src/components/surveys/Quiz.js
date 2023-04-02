import { on } from 'events'
import React, { useState } from 'react'
import Button from '@mui/material/Button'
import { styled } from '@mui/material/styles';
import Stack from '@mui/material/Stack';
import { purple } from '@mui/material/colors';

const quiz = {
    topic: 'Javascript',
    level: 'Beginner',
    totalQuestions: 4,
    perQuestionScore: 5,
    totalTime: 60, // in seconds
    questions: [
      {
        question:
          'What country consumes the most energy in the world?',
        choices: ['Russia', 'China', 'the United States', 'Canada'],
        type: 'MCQs',
        correctAnswer: 'the United States',
      },
      {
        question:
          'What country produces the most energy in the world?',
        choices: ['Iraq', 'China', 'the United States', 'Russia'],
        type: 'MCQs',
        correctAnswer: 'China',
      },
      {
        question:
          'What is the leading source of energy in the United States?',
        choices: [
          'Coal',
          'Oil',
          'Nuclear power',
          'Natural gas',
        ],
        type: 'MCQs',
        correctAnswer: 'Natural gas',
      },
      {
        question: 'How can a datatype be declared to be a constant type?',
        choices: ['Hydropower', 'Petroleum', 'Biomass', 'Solar power'],
        type: 'MCQs',
        correctAnswer: 'Biomass',
      },
    ],
  }
  
  
  export const Quiz = () => {
    const BootstrapButton = styled(Button)({
      boxShadow: 'none',
      textTransform: 'none',
      fontSize: 16,
      padding: '6px 12px',
      border: '1px solid',
      lineHeight: 1.5,
      backgroundColor: '#0063cc',
      borderColor: '#0063cc',
      fontFamily: [
        '-apple-system',
        'BlinkMacSystemFont',
        '"Segoe UI"',
        'Roboto',
        '"Helvetica Neue"',
        'Arial',
        'sans-serif',
        '"Apple Color Emoji"',
        '"Segoe UI Emoji"',
        '"Segoe UI Symbol"',
      ].join(','),
      '&:hover': {
        backgroundColor: '#0069d9',
        borderColor: '#0062cc',
        boxShadow: 'none',
      },
      '&:active': {
        boxShadow: 'none',
        backgroundColor: '#0062cc',
        borderColor: '#005cbf',
      },
      '&:focus': {
        boxShadow: '0 0 0 0.2rem rgba(0,123,255,.5)',
      },
    });
    
    const [activeQuestion, setActiveQuestion] = React.useState(0)
    const [selectedAnswer, setSelectedAnswer] = React.useState('')
    const [showResult, setShowResult] = React.useState(false)
    const [selectedAnswerIndex, setSelectedAnswerIndex] = React.useState(null)
    const [result, setResult] = React.useState({
      score: 0,
      correctAnswers: 0,
      wrongAnswers: 0,
    })
  
    const { questions } = quiz
    const { question, choices, correctAnswer } = questions[activeQuestion]
  
    const onClickNext = () => {
      setSelectedAnswerIndex(null)
      setResult((prev) =>
        selectedAnswer
          ? {
              ...prev,
              score: prev.score + 5,
              correctAnswers: prev.correctAnswers + 1,
            }
          : { ...prev, wrongAnswers: prev.wrongAnswers + 1 }
      )
      if (activeQuestion !== questions.length - 1) {
        setActiveQuestion((prev) => prev + 1)
      } else {
        setActiveQuestion(0)
        setShowResult(true)
      }
    }
  
    const onAnswerSelected = (answer, index) => {
      setSelectedAnswerIndex(index)
      if (answer === correctAnswer) {
        setSelectedAnswer(true)
      } else {
        setSelectedAnswer(false)
      }
    }
    function handleKeyDown(e) {
        if (e.keyCode === 13) {
          onAnswerSelected(e.answer, e.index);
        }
      }
  
    const addLeadingZero = (number) => (number > 9 ? number : `0${number}`)
  
    return (
      <div className="quiz-container">
        {!showResult ? (
          <div>
            <div>
              <span className="active-question-no">
                {addLeadingZero(activeQuestion + 1)}
              </span>
              <span className="total-question">
                /{addLeadingZero(questions.length)}
              </span>
            </div>
            <h2>{question}</h2>
            <ul>
              {choices.map((answer, index) => (
                <BootstrapButton style={{background:'#c1dab7', display:'block', margin:'0.3rem' }} role = "button" onClick={() => onAnswerSelected(answer, index)} onKeyDown={(answer, index)}
                  key={answer}
                  className={
                    selectedAnswerIndex === index ? 'selected-answer' : null
                  }
                >
                  {answer}
                </BootstrapButton>
              ))}
            </ul>
            <div className="flex-right">
              <BootstrapButton onClick={onClickNext} style={{margin:'1rem'}}
                disabled={selectedAnswerIndex === null} variant="contained" disableRipple>
                {activeQuestion === questions.length - 1 ? 'Finish' : 'Next'}
              </BootstrapButton>
            </div>
          </div>
        ) : (
          <div className="result">
            <h3>Result</h3>
            <p>
              Total Question: <span>{questions.length}</span>
            </p>
            <p>
              Total Score:<span> {result.score}</span>
            </p>
            <p>
              Correct Answers:<span> {result.correctAnswers}</span>
            </p>
            <p>
              Wrong Answers:<span> {result.wrongAnswers}</span>
            </p>
            <h3>Your next product is a Reusable bag</h3>
          </div>
        )}
      </div>
    )
  }
  