﻿using eAppointmentServer.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace eAppointmentServer.Application.Features.Appointments.GetAllDoctorsByDepartment;

public sealed record GetAllDoctorsByDepartmentQuery(
    int DepartmentValue) : IRequest<Result<List<Doctor>>>;
