# [P.O.C] HANGFIRE
### [English](READMEEnglish.md)

## Finalidade desse Repositorio

O Objetivo desses repositorios [POCs] é demostrar qualquer prova de conceito.

## HANGFIRE

O Hangfire é um biblioteca open-source para programação de tarefas em segundo plano em aplicações .NET.
Ele permite que os desenvolvedores agendem tarefas para serem executadas em um momento específico no futuro, ou em intervalos regulares, sem a necessidade de gerenciamento manual do agendamento de threads ou processos.

Foi criado para lidar com situações em que as tarefas precisam ser executadas de forma assíncrona e fora do contexto da solicitação HTTP em aplicações web, como processamento de longa duração, envio de e-mails em massa, geração de relatórios, entre outras.

## Conceitos
### Recurring Jobs
O Recurrig Jobs são tarefas agendadas para serem executadas em intervalos regulares, por exemplo podemos agendar para a cada hora, semana ou dia... Os trabalhos recorrentes no Hangfire permitem automatizar processos que precisam ser executados repetidamente em sua aplicação.
